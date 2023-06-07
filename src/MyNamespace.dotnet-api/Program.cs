using System.Data;
using idunno.Authentication.Basic;
using MediatR;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Steeltoe.Extensions.Configuration.ConfigServer;
using MyNamespace.Common;
using MyNamespace.Common.Configuration;
using MyNamespace.Common.Messaging;
using MyNamespace.Common.Modules;
using MyNamespace.Common.Persistence;
using MyNamespace.Common.Security;
using MyNamespace.Common.Swagger;
using MyNamespace.dotnet-api;
using MyNamespace.dotnet-api.Persistence;
using Steeltoe.Common.HealthChecks;
using Steeltoe.Connector;
using Steeltoe.Extensions.Logging;
using Steeltoe.Management.Endpoint;
using Steeltoe.Management.Tracing;
using DbType = MyNamespace.Common.Persistence.DbType;

var builder = WebApplication.CreateBuilder(args);
builder.UseYamlWithProfilesAppConfiguration<Program>(args);
BootstrapLoggerFactory.Update(builder.Configuration);
builder.Logging.AddDynamicConsole();
var configuration = builder.Configuration;
var services = builder.Services;

// add all steeltoe actuators, but make them only respond on a management port
var managementPort = builder.Configuration.GetValue<uint>("Management:Port");
builder.WebHost.AddAllActuators(c =>
{
    if (managementPort > 0)
    {
        c.RequireHost($"*:{managementPort}");
    }
});
if (builder.Environment.IsDevelopment())
{
    // remove zipkin trace ids from logs when running in local development
    services.AddSingleton<IDynamicMessageProcessor, NullLogProcessor>();
}
services.AddDistributedTracingAspNetCore();
// services.AddAllActuators();
// services.AddSingleton<IStartupFilter>(new AllActuatorsStartupFilter(c => c.RequireHost($"*:{managementPort}")));
// register with Spring Boot Admin if integration is enabled. Spring boot admin will scrape this apps actuators and display in GUI
// spring boot admin can be used instead of TAP LiveView when running locally
if (configuration.GetValue<string>("Spring:Boot:Admin:Client:Url") != null)
{
    services.AddSpringBootAdmin();
}

services.AddConfigServerHealthContributor();

services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(cfg =>
    {
        cfg.ForwardDefaultSelector = httpContext => (httpContext.Request.Path.StartsWithSegments("/actuator")? BasicAuthenticationDefaults.AuthenticationScheme : null)!;
        configuration.GetSection($"Authentication:{JwtBearerDefaults.AuthenticationScheme}").Bind(cfg);
    });
services.AddAuthorization(authz =>
{
    authz.AddPolicy(KnownAuthorizationPolicy.AirportRead, policy => policy.RequireScope(KnownScope.Read));
    authz.AddPolicy(KnownAuthorizationPolicy.WeatherRead, policy => policy.RequireScope(KnownScope.Read));
    authz.AddPolicy(KnownAuthorizationPolicy.WeatherWrite, policy => policy.RequireScope(KnownScope.Write));
});
services.AddMediatR(cfg => cfg.Using<MessageBus>(), typeof(Program));
services.AddTransient(svc => (IMessageBus) svc.GetRequiredService<IMediator>());
services.AddModules();
services.AddDbContext<dotnet-apiContext>(opt =>
{
    var connectionString = configuration.GetConnectionString("database");
    var dbDriver = configuration.GetValue<DbType>("DbType");
    switch (dbDriver)
    {
        case DbType.SQLite:
            if (connectionString.Contains(":memory") || connectionString.Contains("mode=memory"))
            {
                // in memory database needs to have its connection permanently open or it will get auto-deleted
                var keepAliveConnection = new SqliteConnection(connectionString);
                keepAliveConnection.Open();
                opt.UseSqlite(keepAliveConnection);
            }
            else
            {
                opt.UseSqlite(connectionString);
            }

            break;
        case DbType.PostgreSQL:
            opt.UseNpgsql(connectionString);
            break;

    }
});
services.AddScoped<IDbConnection>(ctx => ctx.GetRequiredService<dotnet-apiContext>().Database.GetDbConnection());
services.AddScoped<IHealthContributor, RelationalDbHealthContributor>(); // allow db connection health to show up in actuator health endpoint
services.AddControllers(cfg => cfg.Filters.Add<DomainExceptionFilter>()); // respond with HTTP400 if domain exception is thrown
services.AddSwaggerGen(c =>
{
    c.UseOperationIdsConventions();
    c.SwaggerDoc("v1", new OpenApiInfo {Title = "MyNamespace.dotnet-api", Version = "v1"});
});

var app = builder.Build();
BootstrapLoggerFactory.Update(app.Services.GetRequiredService<ILoggerFactory>());
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.MigrateDatabase<dotnet-apiContext>();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyNamespace.dotnet-api v1");
});
app.UseRouting();
// app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.Run();
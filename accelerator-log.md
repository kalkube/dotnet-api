# Accelerator Log

## Options
```json
{
  "configserver" : true,
  "database" : "postgresql",
  "enableSecurity" : true,
  "namespace" : "MyNamespace",
  "projectName" : "dotnet-api"
}
```
## Log
```
┏ engine (Chain)
┃  Info Running Chain(GeneratorValidationTransform, UniquePath)
┃ ┏ ┏ engine.transformations[0].validated (Combo)
┃ ┃ ┃  Info Combo running as Let
┃ ┃ ┃ engine.transformations[0].validated.delegate (Let)
┃ ┃ ┃ Debug Adding symbol postgresql with value 'true'
┃ ┃ ┃ Debug Adding symbol mysql with value 'false'
┃ ┃ ┃ Debug Adding symbol sourceNameLower with value 'dotnet-api'
┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in (Chain)
┃ ┃ ┃ ┃  Info Running Chain(Chain, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, RewritePath, ReplaceText, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0] (Chain)
┃ ┃ ┃ ┃ ┃  Info Running Chain(Merge, UniquePath)
┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0] (Merge)
┃ ┃ ┃ ┃ ┃ ┃  Info Running Merge(Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo, Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[0] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[0].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, Exclude)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[0].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [**]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[0].delegate.transformations[1] (Exclude)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will exclude [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md matched [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml matched [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform matched [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql matched [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json matched [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml matched [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml matched [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs matched [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs matched [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs matched [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗ Debug version.json didn't match [.template.config/**, src/DotnetAccelerator/Security/**, **/*MySQL*, **/*PostgreSQL*, **/*PostgreSQL*, **/Migrations/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[1] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Include
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[1].delegate (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/DotnetAccelerator/Security/**]
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/DotnetAccelerator/Security/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[2] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#mysql) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┗ null ()
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[3] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#postgresql) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Include
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[3].delegate (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [**/*PostgreSQL*, **/*PostgreSQL*]
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml matched [**/*PostgreSQL*, **/*PostgreSQL*] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [**/*PostgreSQL*, **/*PostgreSQL*] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[4] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[4].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[4].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj matched [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/MyProjectGroup.Common/MyProjectGroup.Common.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[4].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#configserver)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[4].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#configserver) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [        <!--#if configserver -->
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         <PackageReference Include="Steeltoe.Extensions.Configuration.ConfigServerCore" Version="3.1.3" />
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info         <!--#endif -->->        <PackageRefe...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[5] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[5].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText, ReplaceText, ReplaceText, ReplaceText, ReplaceText, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[5].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj matched [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[5].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#enableSecurity)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[5].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [        <!--#if enableSecurity -->
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="6.0.3" />
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         <PackageReference Include="idunno.Authentication.Basic" Version="2.2.3" />
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info         <!--#endif -->->        <PackageRefe...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[5].delegate.transformations[3] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#postgresql)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[5].delegate.transformations[4] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#postgresql) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [        <!--#if postgresql -->
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         <PackageReference Include="Npgsql.EntityFrameworkCore.PostgreSQL" Version="6.0.3" />
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info         <!--#endif -->->        <PackageRefe...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[5].delegate.transformations[5] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (!(#mysql)) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [        <!--#if mysql -->
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         <PackageReference Include="Pomelo.EntityFrameworkCore.MySql" Version="6.0.1" />
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info         <!--#endif -->->]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[5].delegate.transformations[6] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (#mysql) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[5].delegate.transformations[7] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#configserver)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[5].delegate.transformations[8] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#configserver) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [        <!--#if configserver -->
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         <PackageReference Include="Steeltoe.Extensions.Configuration.ConfigServerCore" Version="$(SteeltoeVersion)" />
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info         <!--#endif -->->        <PackageRefe...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[6] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[6].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[6].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [config/application-Development.yaml]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml matched [config/application-Development.yaml] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [config/application-Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[6].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#enableSecurity)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[6].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info   Bearer:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     Authority: https://login.run.pcfone.io
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info   Be...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[7] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[7].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[7].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [config/application.yaml]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml matched [config/application.yaml] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [config/application.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[7].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#enableSecurity)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[7].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info   Bearer:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     Authority: https://accounts.google.com
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info   Be...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[8] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[8].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText, ReplaceText, ReplaceText, ReplaceText, ReplaceText, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[8].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/MyProjectGroup.DotnetAccelerator/Program.cs]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs matched [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/MyProjectGroup.DotnetAccelerator/Program.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[8].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#enableSecurity)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[8].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info using Microsoft.AspNetCore.Authentication.JwtBearer;
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->using Microsoft.AspN...(truncated), #if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     .AddJwtBearer(cfg =>
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     {
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         cfg.ForwardDefaultSelector = httpContext => (httpContext.Request.Path.StartsWithSegments("/actuator")? BasicAuthenticationDefaults.AuthenticationScheme : null)!;
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         configuration.GetSection($"Authentication:{JwtBearerDefaults.AuthenticationScheme}").Bind(cfg);
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     });
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info services.AddAuthorization(authz =>
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info {
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     authz.AddPolicy(KnownAuthorizationPolicy.AirportRead, policy => policy.RequireScope(KnownScope.Read));
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     authz.AddPolicy(KnownAuthorizationPolicy.WeatherRead, policy => policy.RequireScope(KnownScope.Read));
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     authz.AddPolicy(KnownAuthorizationPolicy.WeatherWrite, policy => policy.RequireScope(KnownScope.Write));
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info });
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info #endif->services.AddAuthenti...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[8].delegate.transformations[3] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#configserver)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[8].delegate.transformations[4] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#configserver) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if configserver
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info using Steeltoe.Extensions.Configuration.ConfigServer;
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->using Steeltoe.Exten...(truncated), #if configserver
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info services.AddConfigServerHealthContributor();
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info #endif->services.AddConfigSe...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[8].delegate.transformations[5] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#postgresql)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[8].delegate.transformations[6] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#postgresql) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if postgresql
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         case DbType.PostgreSQL:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info             opt.UseNpgsql(connectionString);
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info             break;
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info #endif->        case DbType....(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[8].delegate.transformations[7] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (!(#mysql)) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if mysql
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         case DbType.MySQL:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info             opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info             break;
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info #endif->]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[8].delegate.transformations[8] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info Condition (#mysql) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[9] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[9].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[9].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs matched [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[9].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#configserver)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[9].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#configserver) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if configserver
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info using Steeltoe.Extensions.Configuration.ConfigServer;
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->using Steeltoe.Exten...(truncated), #if configserver
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info             bootstrapConfigBuilder.AddEnvironmentVariables()
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info             .AddCommandLine(Environment.GetCommandLineArgs())
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info             .AddProfiles();
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info             BootstrapLoggerFactory.Update(bootstrapConfigBuilder.Build());
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info             bootstrapConfigBuilder.AddConfigServer(environment, BootstrapLoggerFactory.Instance);
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info #endif->            bootstra...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[10] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[10].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[10].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[10].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#enableSecurity)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[10].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info   Bearer:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     Authority: https://login.run.pcfone.io
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info   Be...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[11] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[11].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[11].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/.buildsync/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[11].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#enableSecurity)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[11].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info   Bearer:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     Authority: https://accounts.google.com
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info   Be...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[12] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[12].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[12].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json matched [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[12].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#postgresql)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[12].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#postgresql) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [//#if postgresql
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     "DotnetAccelerator - PostgreSQL: ": {
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info       "commandName": "Project",
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info       "dotnetRunMessages": "true",
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info       "launchBrowser": true,
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info       "applicationUrl": "https://localhost:5001;http://localhost:5000;http://localhost:8090",
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info       "environmentVariables": {
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         "ASPNETCORE_ENVIRONMENT": "Development",
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         "SPRING:PROFILES:ACTIVE": "LocalPostgreSQL"
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info       }
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     },
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info //#endif->    "DotnetAccelerat...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[12].delegate.transformations[3] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (!(#mysql)) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [//#if mysql
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     "DotnetAccelerator - MySQL: ": {
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info       "commandName": "Project",
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info       "dotnetRunMessages": "true",
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info       "launchBrowser": true,
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info       "applicationUrl": "https://localhost:5001;http://localhost:5000;http://localhost:8090",
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info       "environmentVariables": {
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         "ASPNETCORE_ENVIRONMENT": "Development",
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         "SPRING:PROFILES:ACTIVE": "LocalMySQL"
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info       }
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     },
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info //#endif->]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[12].delegate.transformations[4] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info Condition (#mysql) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[13] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[13].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[13].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[13].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#enableSecurity)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[13].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info   Bearer:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     Authority: https://login.run.pcfone.io
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info   Be...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[14] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[14].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[14].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/MyProjectGroup.Common/Persistence/DbType.cs]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs matched [src/MyProjectGroup.Common/Persistence/DbType.cs] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/MyProjectGroup.Common/Persistence/DbType.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[14].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#postgresql)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[14].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#postgresql) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if postgresql
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         PostgreSQL,
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info #endif->        PostgreSQL,]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[14].delegate.transformations[3] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (!(#mysql)) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if mysql
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         MySQL,
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info #endif->]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[14].delegate.transformations[4] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info Condition (#mysql) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[15] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[15].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[15].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[15].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#enableSecurity)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[15].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info   Bearer:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     Authority: https://accounts.google.com
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info   Be...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[16] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[16].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[16].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs matched [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[16].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#enableSecurity)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[16].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         public const string AirportRead = "airport.read";
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         public const string WeatherRead = "airport.read";
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         public const string WeatherWrite = "airport.read";
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info #endif->        public const...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[17] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[17].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[17].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[17].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#enableSecurity)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[17].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info   Bearer:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     Authority: https://login.run.pcfone.io
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info   Be...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[18] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[18].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[18].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [tests/DotnetAcceleratorTests/bin/Debug/net6.0/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[18].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#enableSecurity)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[18].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info   Bearer:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     Authority: https://accounts.google.com
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info   Be...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[19] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[19].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[19].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.Development.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[19].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#enableSecurity)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[19].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info   Bearer:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     Authority: https://login.run.pcfone.io
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info   Be...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[20] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[20].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[20].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/MyProjectGroup.DotnetAccelerator/bin/Debug/net6.0/ubuntu.18.04-x64/config/solution-defaults.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[20].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#enableSecurity)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[20].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info   Bearer:
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info     Authority: https://accounts.google.com
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->Authentication:
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info   Be...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[21] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[21].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[21].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs matched [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[21].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#enableSecurity)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[21].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info using MyProjectGroup.Common.Security;
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->using MyProjectGroup...(truncated), #if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         [Authorize(KnownAuthorizationPolicy.AirportRead)]
┃ ┃ ┃ ┃ ┃ ┃ ┗ ┗  Info #endif->        [Authorize(K...(truncated)]
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[22] (Combo)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Combo running as Chain
┃ ┃ ┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[22].delegate (Chain)
┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[22].delegate.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will include [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .config/dotnet-tools.json didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .dockerignore didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitattributes didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .github/workflows/CI.yml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/build.schema.json didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .nuke/parameters.json didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/myaccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/ConfigurationBuilderExtensions_transform didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/snippets/StartupCs_DbDriver_postgresql didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug .template.config/template.json didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug DotnetAccelerator.sln didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug azure-pipelines.yml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/.editorconfig didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Build.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Configuration.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.props didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/Directory.Build.targets didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/GitVersionAttribute.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/SerilogExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/_build.csproj.DotSettings didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/Tiltfile.template didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build/tilt/deployment.template.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.cmd didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.ps1 didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug build.sh didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalMySQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-LocalPostgreSQL.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator-SQLite.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/DotnetAccelerator.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application-Development.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/application.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug config/config.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug docs/images/config-server-fig1.png didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug kubernetes/workload.yaml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/Eureka.url didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/OmniDB.url didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/PhpMyAdmin.url didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug services/docker-compose.yml didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/BootstrapLoggerFactory.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/IMessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBus.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainException.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/IService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/MyProjectGroup.Common.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/NullLogProcessor.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Persistence/DbType.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/KnownScope.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Dockerfile didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.Designer.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/20211004141718_Initial.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Migrations/DotnetAcceleratorContextModelSnapshot.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs matched [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> included
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Program.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug src/MyProjectGroup.DotnetAccelerator/README.md didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/IUseDbContext.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ Debug tests/DotnetAcceleratorTests/WeatherTests.cs didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Debug version.json didn't match [src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[22].delegate.transformations[1] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗  Info Condition (!(#enableSecurity)) evaluated to false
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[0].sources[22].delegate.transformations[2] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Condition (#enableSecurity) evaluated to true
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info Will replace [#if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info using MyProjectGroup.Common.Security;
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->using MyProjectGroup...(truncated), #if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         [Authorize(KnownAuthorizationPolicy.WeatherRead)]
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info #endif->        [Authorize(K...(truncated), #if enableSecurity
┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃  Info         [Authorize(KnownAuthorizationPolicy.WeatherWrite)]
┃ ┃ ┃ ┃ ┃ ┗ ┗ ┗  Info #endif->        [Authorize(K...(truncated)]
┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[0].transformations[1] (UniquePath)
┃ ┃ ┃ ┃ ┃ ┃ Debug Multiple representations for path 'src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs', will use the one appearing last 
┃ ┃ ┃ ┃ ┃ ┃ Debug Multiple representations for path 'src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj', will use the one appearing last 
┃ ┃ ┃ ┃ ┃ ┃ Debug Multiple representations for path 'src/MyProjectGroup.DotnetAccelerator/Program.cs', will use the one appearing last 
┃ ┃ ┃ ┃ ┃ ┃ Debug Multiple representations for path 'src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs', will use the one appearing last 
┃ ┃ ┃ ┃ ┃ ┃ Debug Multiple representations for path 'src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json', will use the one appearing last 
┃ ┃ ┃ ┃ ┃ ┃ Debug Multiple representations for path 'config/application-Development.yaml', will use the one appearing last 
┃ ┃ ┃ ┃ ┃ ┃ Debug Multiple representations for path 'config/application.yaml', will use the one appearing last 
┃ ┃ ┃ ┃ ┃ ┃ Debug Multiple representations for path 'src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs', will use the one appearing last 
┃ ┃ ┃ ┃ ┃ ┃ Debug Multiple representations for path 'src/MyProjectGroup.Common/Persistence/DbType.cs', will use the one appearing last 
┃ ┃ ┃ ┃ ┃ ┃ Debug Multiple representations for path 'src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs', will use the one appearing last 
┃ ┃ ┃ ┃ ┗ ┗ Debug Multiple representations for path 'src/MyProjectGroup.Common/MyProjectGroup.Common.csproj', will use the one appearing last 
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[1] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'config/DotnetAccelerator-Development.yaml' matched 'config/DotnetAccelerator-Development.yaml' with groups {g0=config/DotnetAccelerator-Development.yaml} and was rewritten to 'config/dotnet-api-Development.yaml'
┃ ┃ ┃ ┃ ╺ engine.transformations[0].validated.delegate.in.transformations[2] (RewritePath)
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[3] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'config/DotnetAccelerator-LocalPostgreSQL.yaml' matched 'config/DotnetAccelerator-LocalPostgreSQL.yaml' with groups {g0=config/DotnetAccelerator-LocalPostgreSQL.yaml} and was rewritten to 'config/dotnet-api-LocalPostgreSQL.yaml'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[4] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'config/DotnetAccelerator-SQLite.yaml' matched 'config/DotnetAccelerator-SQLite.yaml' with groups {g0=config/DotnetAccelerator-SQLite.yaml} and was rewritten to 'config/dotnet-api-SQLite.yaml'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[5] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'config/DotnetAccelerator.yaml' matched 'config/DotnetAccelerator.yaml' with groups {g0=config/DotnetAccelerator.yaml} and was rewritten to 'config/dotnet-api.yaml'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[6] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'DotnetAccelerator.sln' matched 'DotnetAccelerator.sln' with groups {g0=DotnetAccelerator.sln} and was rewritten to 'dotnet-api.sln'
┃ ┃ ┃ ┃ ╺ engine.transformations[0].validated.delegate.in.transformations[7] (RewritePath)
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[8] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/BootstrapLoggerFactory.cs' matched 'src/MyProjectGroup.Common/BootstrapLoggerFactory.cs' with groups {g0=src/MyProjectGroup.Common/BootstrapLoggerFactory.cs} and was rewritten to 'src/MyNamespace.Common/BootstrapLoggerFactory.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[9] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs' matched 'src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs' with groups {g0=src/MyProjectGroup.Common/Configuration/ConfigurationBuilderExtensions.cs} and was rewritten to 'src/MyNamespace.Common/Configuration/ConfigurationBuilderExtensions.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[10] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Messaging/IMessageBus.cs' matched 'src/MyProjectGroup.Common/Messaging/IMessageBus.cs' with groups {g0=src/MyProjectGroup.Common/Messaging/IMessageBus.cs} and was rewritten to 'src/MyNamespace.Common/Messaging/IMessageBus.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[11] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Messaging/MessageBus.cs' matched 'src/MyProjectGroup.Common/Messaging/MessageBus.cs' with groups {g0=src/MyProjectGroup.Common/Messaging/MessageBus.cs} and was rewritten to 'src/MyNamespace.Common/Messaging/MessageBus.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[12] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs' matched 'src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs' with groups {g0=src/MyProjectGroup.Common/Messaging/MessageBusServiceCollectionExtensions.cs} and was rewritten to 'src/MyNamespace.Common/Messaging/MessageBusServiceCollectionExtensions.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[13] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Modules/DomainException.cs' matched 'src/MyProjectGroup.Common/Modules/DomainException.cs' with groups {g0=src/MyProjectGroup.Common/Modules/DomainException.cs} and was rewritten to 'src/MyNamespace.Common/Modules/DomainException.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[14] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs' matched 'src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs' with groups {g0=src/MyProjectGroup.Common/Modules/DomainExceptionFilter.cs} and was rewritten to 'src/MyNamespace.Common/Modules/DomainExceptionFilter.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[15] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Modules/IService.cs' matched 'src/MyProjectGroup.Common/Modules/IService.cs' with groups {g0=src/MyProjectGroup.Common/Modules/IService.cs} and was rewritten to 'src/MyNamespace.Common/Modules/IService.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[16] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs' matched 'src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs' with groups {g0=src/MyProjectGroup.Common/Modules/ServiceCollectionExtensions.cs} and was rewritten to 'src/MyNamespace.Common/Modules/ServiceCollectionExtensions.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[17] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/MyProjectGroup.Common.csproj' matched 'src/MyProjectGroup.Common/MyProjectGroup.Common.csproj' with groups {g0=src/MyProjectGroup.Common/MyProjectGroup.Common.csproj} and was rewritten to 'src/MyNamespace.Common/MyNamespace.Common.csproj'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[18] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/NullLogProcessor.cs' matched 'src/MyProjectGroup.Common/NullLogProcessor.cs' with groups {g0=src/MyProjectGroup.Common/NullLogProcessor.cs} and was rewritten to 'src/MyNamespace.Common/NullLogProcessor.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[19] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs' matched 'src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs' with groups {g0=src/MyProjectGroup.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs} and was rewritten to 'src/MyNamespace.Common/Persistence/DbContextMigrationApplicationBuilderExtensions.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[20] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs' matched 'src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs' with groups {g0=src/MyProjectGroup.Common/Persistence/DbContextMigrator.cs} and was rewritten to 'src/MyNamespace.Common/Persistence/DbContextMigrator.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[21] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Persistence/DbType.cs' matched 'src/MyProjectGroup.Common/Persistence/DbType.cs' with groups {g0=src/MyProjectGroup.Common/Persistence/DbType.cs} and was rewritten to 'src/MyNamespace.Common/Persistence/DbType.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[22] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs' matched 'src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs' with groups {g0=src/MyProjectGroup.Common/Security/AuthorizationPolicyBuilderExtensions.cs} and was rewritten to 'src/MyNamespace.Common/Security/AuthorizationPolicyBuilderExtensions.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[23] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs' matched 'src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs' with groups {g0=src/MyProjectGroup.Common/Security/KnownAuthorizationPolicy.cs} and was rewritten to 'src/MyNamespace.Common/Security/KnownAuthorizationPolicy.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[24] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Security/KnownScope.cs' matched 'src/MyProjectGroup.Common/Security/KnownScope.cs' with groups {g0=src/MyProjectGroup.Common/Security/KnownScope.cs} and was rewritten to 'src/MyNamespace.Common/Security/KnownScope.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[25] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs' matched 'src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs' with groups {g0=src/MyProjectGroup.Common/Security/ServiceCollectionExtensions.cs} and was rewritten to 'src/MyNamespace.Common/Security/ServiceCollectionExtensions.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[26] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs' matched 'src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs' with groups {g0=src/MyProjectGroup.Common/Swagger/SwaggerGenOptionsExtensions.cs} and was rewritten to 'src/MyNamespace.Common/Swagger/SwaggerGenOptionsExtensions.cs'
┃ ┃ ┃ ┃ ╺ engine.transformations[0].validated.delegate.in.transformations[27] (RewritePath)
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[28] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Dockerfile' matched 'src/MyProjectGroup.DotnetAccelerator/Dockerfile' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Dockerfile} and was rewritten to 'src/MyNamespace.dotnet-api/Dockerfile'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[29] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportController.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Modules/AirportModule/AirportController.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[30] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Modules/AirportModule/AirportService.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[31] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/AirportService.Handlers.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Modules/AirportModule/AirportService.Handlers.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[32] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/Airport.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Modules/AirportModule/Api/Airport.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[33] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Modules/AirportModule/Api/AirportQuery.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[34] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Modules/AirportModule/Api/AirportQuery.MediatR.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Modules/AirportModule/Api/AirportQuery.MediatR.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[35] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Modules/HomeController.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Modules/HomeController.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[36] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Modules/WeatherModule/Api/WeatherForecast.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[37] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Modules/WeatherModule/Api/WeatherForecast.MediatR.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[38] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Modules/WeatherModule/Api/WeatherForecastQuery.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[39] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Modules/WeatherModule/Api/WeatherForecastQuery.MediatR.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[40] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherController.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Modules/WeatherModule/WeatherController.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[41] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Modules/WeatherModule/WeatherService.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[42] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Modules/WeatherModule/WeatherService.Handlers.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Modules/WeatherModule/WeatherService.Handlers.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[43] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj' matched 'src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj' with groups {g0=src/MyProjectGroup.DotnetAccelerator/MyProjectGroup.DotnetAccelerator.csproj} and was rewritten to 'src/MyNamespace.dotnet-api/MyNamespace.dotnet-api.csproj'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[44] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Persistence/DotnetAcceleratorContext.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Persistence/dotnet-apiContext.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[45] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Program.cs' matched 'src/MyProjectGroup.DotnetAccelerator/Program.cs' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Program.cs} and was rewritten to 'src/MyNamespace.dotnet-api/Program.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[46] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json' matched 'src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json' with groups {g0=src/MyProjectGroup.DotnetAccelerator/Properties/launchSettings.json} and was rewritten to 'src/MyNamespace.dotnet-api/Properties/launchSettings.json'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[47] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'src/MyProjectGroup.DotnetAccelerator/README.md' matched 'src/MyProjectGroup.DotnetAccelerator/README.md' with groups {g0=src/MyProjectGroup.DotnetAccelerator/README.md} and was rewritten to 'src/MyNamespace.dotnet-api/README.md'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[48] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj' matched 'tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj' with groups {g0=tests/DotnetAcceleratorTests/DotnetAcceleratorTests.csproj} and was rewritten to 'tests/dotnet-apiTests/dotnet-apiTests.csproj'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[49] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'tests/DotnetAcceleratorTests/IUseDbContext.cs' matched 'tests/DotnetAcceleratorTests/IUseDbContext.cs' with groups {g0=tests/DotnetAcceleratorTests/IUseDbContext.cs} and was rewritten to 'tests/dotnet-apiTests/IUseDbContext.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[50] (RewritePath)
┃ ┃ ┃ ┃ ┗ Debug Path 'tests/DotnetAcceleratorTests/WeatherTests.cs' matched 'tests/DotnetAcceleratorTests/WeatherTests.cs' with groups {g0=tests/DotnetAcceleratorTests/WeatherTests.cs} and was rewritten to 'tests/dotnet-apiTests/WeatherTests.cs'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[51] (ReplaceText)
┃ ┃ ┃ ┃ ┗  Info Will replace [MyProjectGroup->MyNamespace]
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[52] (ReplaceText)
┃ ┃ ┃ ┃ ┗  Info Will replace [dotnetaccelerator->dotnet-api]
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.delegate.in.transformations[53] (ReplaceText)
┃ ┗ ┗ ┗ ┗  Info Will replace [DotnetAccelerator->dotnet-api]
┗ ╺ engine.transformations[1] (UniquePath)
```

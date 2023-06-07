using Microsoft.EntityFrameworkCore;
using MyNamespace.dotnet-api.Modules.AirportModule.Api;
using MyNamespace.dotnet-api.Modules.WeatherModule.Api;

namespace MyNamespace.dotnet-api.Persistence
{
    public class dotnet-apiContext : DbContext
    {
        protected dotnet-apiContext()
        {
        }

        public dotnet-apiContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<WeatherForecast> WeatherForecasts => Set<WeatherForecast>();
        public DbSet<Airport> Airports => Set<Airport>();
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airport>().HasData(new Airport {Id = "YYZ", Name = "Toronto"});
            modelBuilder.Entity<Airport>().HasData(new Airport {Id = "JFK", Name = "New York"});
        }
    }
}
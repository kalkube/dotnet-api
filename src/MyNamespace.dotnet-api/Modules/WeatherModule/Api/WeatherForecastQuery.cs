using System;

namespace MyNamespace.dotnet-api.Modules.WeatherModule.Api
{
    public partial class WeatherForecastQuery
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? AirportId { get; set; }
    }
}
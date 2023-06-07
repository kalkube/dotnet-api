using System.Collections.Generic;
using MediatR;

namespace MyNamespace.dotnet-api.Modules.WeatherModule.Api
{
    partial class WeatherForecastQuery : IRequest<IAsyncEnumerable<WeatherForecast>>
    {
        
    }
}
using System.Collections.Generic;
using System.Linq;
using LinqKit;
using Microsoft.Extensions.Logging;
using MyNamespace.Common.Modules;
using MyNamespace.dotnet-api.Modules.AirportModule.Api;
using MyNamespace.dotnet-api.Modules.WeatherModule;
using MyNamespace.dotnet-api.Persistence;

namespace MyNamespace.dotnet-api.Modules.AirportModule
{
    public partial class AirportService : IService
    {
        private readonly dotnet-apiContext _context;
        private readonly ILogger _logger;

        public AirportService(dotnet-apiContext context, ILogger<AirportService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public IAsyncEnumerable<Airport> GetAirports(AirportQuery query)
        {
            var predicate = PredicateBuilder.New<Airport>(true);
            if (query.AirportId != null)
            {
                predicate = predicate.And(x => x.Id == query.AirportId);
            }

            return _context.Airports
                .AsQueryable()
                .Where(predicate)
                .ToAsyncEnumerable();
        }
    }
}
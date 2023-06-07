using System.Collections.Generic;
using MediatR;

namespace MyNamespace.dotnet-api.Modules.AirportModule.Api
{
    partial class AirportQuery : IRequest<IAsyncEnumerable<Airport>>
    {
        
    }
}
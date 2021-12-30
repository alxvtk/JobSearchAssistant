using JsaCqrsApi.Infrastructure.Context;
using JsaCqrsApi.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.LocationFeatures.Queries
{
    public class GetAllLocationsQuery : IRequest<IEnumerable<Location>>
    {
        public class GetAllLocationsQureyHandler : IRequestHandler<GetAllLocationsQuery, IEnumerable<Location>>
        {
            private readonly IApplicationContext _context;
            public GetAllLocationsQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Location>> Handle(GetAllLocationsQuery request, CancellationToken cancellationToken)
            {
                var location = await _context.Locations.ToListAsync();
                if (location == null)
                {
                    return null;
                }
                return location.AsReadOnly();
            }
        }
    }
}

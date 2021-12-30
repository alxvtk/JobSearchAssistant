using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.LocationFeatures.Queries
{
    public class GetLocationByIdQuery : IRequest<Location>
    {
        public int Id { get; set; }
        public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, Location>
        {
            private readonly IApplicationContext _context;
            public GetLocationByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<Location> Handle(GetLocationByIdQuery query, CancellationToken cancellationToken)
            {
                var location = _context.Locations.Where(a => a.Id == query.Id).FirstOrDefault();
                if (location == null) return null;
                return location;
            }
        }

    }
}

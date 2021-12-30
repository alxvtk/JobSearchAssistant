using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.CountryFeatures.Queries
{
    public class GetCountryByIdQuery : IRequest<Country>
    {
        public int Id { get; set; }
        public class GetCountryByIdQueryHandler : IRequestHandler<GetCountryByIdQuery, Country>
        {
            private readonly IApplicationContext _context;
            public GetCountryByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<Country> Handle(GetCountryByIdQuery query, CancellationToken cancellationToken)
            {
                var country = _context.Countries.Where(a => a.Id == query.Id).FirstOrDefault();
                if (country == null) return null;
                return country;
            }
        }


    }
}

using JsaCqrsApi.Infrastructure.Context;
using JsaCqrsApi.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.CountryFeatures.Queries
{
    public class GetAllCountrysQuery : IRequest<IEnumerable<Country>>
    {
        public class GetAllCountrysQueryHandler : IRequestHandler<GetAllCountrysQuery, IEnumerable<Country>>
        {
            private readonly IApplicationContext _context;
            public GetAllCountrysQueryHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Country>> Handle(GetAllCountrysQuery request, CancellationToken cancellationToken)
            {
                var countryList = await _context.Countries.ToListAsync();
                if (countryList == null)
                {
                    return null;
                }
                return countryList.AsReadOnly();
            }
        }
    }
}

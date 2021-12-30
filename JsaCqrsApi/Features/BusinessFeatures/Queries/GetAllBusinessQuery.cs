using JsaCqrsApi.Infrastructure.Context;
using JsaCqrsApi.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.BusinessFeatures.Queries
{
    public class GetAllBusinessesQuery : IRequest<IEnumerable<Business>>
    {
        public class GetAllBusinessesQureyHandler : IRequestHandler<GetAllBusinessesQuery, IEnumerable<Business>>
        {
            private readonly IApplicationContext _context;
            public GetAllBusinessesQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Business>> Handle(GetAllBusinessesQuery request, CancellationToken cancellationToken)
            {
                var businessList = await _context.Businesses.ToListAsync();
                if (businessList == null)
                {
                    return null;
                }
                return businessList.AsReadOnly();
            }
        }
    }
}

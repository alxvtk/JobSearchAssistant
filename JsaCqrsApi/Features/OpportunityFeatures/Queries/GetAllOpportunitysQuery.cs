using JsaCqrsApi.Infrastructure.Context;
using JsaCqrsApi.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.OpportunityFeatures.Queries
{
    public class GetAllOpportunitysQuery : IRequest<IEnumerable<Opportunity>>
    {
        public class GetAllOpportunitysQureyHandler : IRequestHandler<GetAllOpportunitysQuery, IEnumerable<Opportunity>>
        {
            private readonly IApplicationContext _context;
            public GetAllOpportunitysQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Opportunity>> Handle(GetAllOpportunitysQuery request, CancellationToken cancellationToken)
            {
                var opportunities = await _context.Opportunities.ToListAsync();
                if (opportunities == null)
                {
                    return null;
                }
                return opportunities.AsReadOnly();
            }
        }
    }
}

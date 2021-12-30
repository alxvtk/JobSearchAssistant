using JsaCqrsApi.Infrastructure.Context;
using JsaCqrsApi.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.OpportunityActionTypeFeatures.Queries
{
    public class GetAllOpportunityActionTypesQuery : IRequest<IEnumerable<OpportunityActionType>>
    {
        public class GetAllOpportunityActionTypesQueryHandler : IRequestHandler<GetAllOpportunityActionTypesQuery, IEnumerable<OpportunityActionType>>
        {
            private readonly IApplicationContext _context;
            public GetAllOpportunityActionTypesQueryHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<OpportunityActionType>> Handle(GetAllOpportunityActionTypesQuery request, CancellationToken cancellationToken)
            {
                var opportunityActionType = await _context.OpportunityActionTypes.ToListAsync();
                if (opportunityActionType == null)
                {
                    return null;
                }
                return opportunityActionType.AsReadOnly();
            }
        }
    }
}

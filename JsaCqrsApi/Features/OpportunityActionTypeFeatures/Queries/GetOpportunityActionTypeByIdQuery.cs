using JsaCqrsApi.Infrastructure.Context;
using JsaCqrsApi.Domain.Models;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.OpportunityActionTypeFeatures.Queries
{
    public class GetOpportunityActionTypeByIdQuery : IRequest<OpportunityActionType>
    {
        public int Id { get; set; }
        public class GetOpportunityActionTypeByIdQueryHandler : IRequestHandler<GetOpportunityActionTypeByIdQuery, OpportunityActionType>
        {
            private readonly IApplicationContext _context;
            public GetOpportunityActionTypeByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<OpportunityActionType> Handle(GetOpportunityActionTypeByIdQuery query, CancellationToken cancellationToken)
            {
                var opportunityActionType = _context.OpportunityActionTypes.Where(a => a.Id == query.Id).FirstOrDefault();
                if (opportunityActionType == null) return null;
                return opportunityActionType;
            }
        }


    }
}

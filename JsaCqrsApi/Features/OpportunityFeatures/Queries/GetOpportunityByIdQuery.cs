using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.OpportunityFeatures.Queries
{
    public class GetOpportunityByIdQuery : IRequest<Opportunity>
    {
        public int Id { get; set; }
        public class GetOpportunityByIdQueryHandler : IRequestHandler<GetOpportunityByIdQuery, Opportunity>
        {
            private readonly IApplicationContext _context;
            public GetOpportunityByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<Opportunity> Handle(GetOpportunityByIdQuery query, CancellationToken cancellationToken)
            {
                var opportunity = _context.Opportunities.Where(a => a.Id == query.Id).FirstOrDefault();
                if (opportunity == null) return null;
                return opportunity;
            }
        }

    }
}

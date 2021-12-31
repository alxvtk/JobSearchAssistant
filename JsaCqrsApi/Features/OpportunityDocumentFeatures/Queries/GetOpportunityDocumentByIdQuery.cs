using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.OpportunityDocumentFeatures.Queries
{
    public class GetOpportunityDocumentByIdQuery : IRequest<OpportunityDocument>
    {
        public int Id { get; set; }
        public class GetOpportunityDocumentByIdQueryHandler : IRequestHandler<GetOpportunityDocumentByIdQuery, OpportunityDocument>
        {
            private readonly IApplicationContext _context;
            public GetOpportunityDocumentByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<OpportunityDocument> Handle(GetOpportunityDocumentByIdQuery query, CancellationToken cancellationToken)
            {
                var opportunityDocument = _context.OpportunityDocuments.Where(a => a.Id == query.Id).FirstOrDefault();
                if (opportunityDocument == null) return null;
                return opportunityDocument;
            }
        }

    }
}

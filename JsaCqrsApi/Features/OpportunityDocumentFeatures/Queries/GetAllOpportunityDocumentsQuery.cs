using JsaCqrsApi.Infrastructure.Context;
using JsaCqrsApi.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.OpportunityDocumentFeatures.Queries
{
    public class GetAllOpportunityDocumentsQuery : IRequest<IEnumerable<OpportunityDocument>>
    {
        public class GetAllSourceTypesQureyHandler : IRequestHandler<GetAllOpportunityDocumentsQuery, IEnumerable<OpportunityDocument>>
        {
            private readonly IApplicationContext _context;
            public GetAllSourceTypesQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<OpportunityDocument>> Handle(GetAllOpportunityDocumentsQuery request, CancellationToken cancellationToken)
            {
                var opportunityDocumentList = await _context.OpportunityDocuments.ToListAsync();
                if (opportunityDocumentList == null)
                {
                    return null;
                }
                return opportunityDocumentList.AsReadOnly();
            }
        }
    }
}

using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.OpportunityDocumentFeatures.Commands
{
    public class UpdateOpportunityDocumentCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int? OpportunityId { get; set; }
        public int? DocumentId { get; set; }

        public class UpdateOpportunityDocumentCommandHandler : IRequestHandler<UpdateOpportunityDocumentCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdateOpportunityDocumentCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateOpportunityDocumentCommand command, CancellationToken cancellationToken)
            {
                var opportunityDocument = _context.OpportunityDocuments.Where(a => a.Id == command.Id).FirstOrDefault();
                if (opportunityDocument == null)
                {
                    return default;
                }
                else
                {
                    opportunityDocument.OpportunityId = command.OpportunityId;
                    opportunityDocument.Document = command.DocumentId;
                    await _context.SaveChangesAsync();
                    return opportunityDocument.Id;
                }
            }

        }


    }
}

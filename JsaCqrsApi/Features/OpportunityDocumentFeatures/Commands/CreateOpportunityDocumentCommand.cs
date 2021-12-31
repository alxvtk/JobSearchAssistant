using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.OpportunityDocumentFeatures.Commands
{
    public class CreateOpportunityDocumentCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int? OpportunityId { get; set; }
        public int? Document { get; set; }

        public class CreateOpportunityDocumentCommandHandler : IRequestHandler<CreateOpportunityDocumentCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateOpportunityDocumentCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateOpportunityDocumentCommand command, CancellationToken cancellationToken)
            {
                var opportunityDocument = new OpportunityDocument();
                opportunityDocument.Id = command.Id;
                opportunityDocument.OpportunityId = command.OpportunityId;
                opportunityDocument.Document = command.Document;

                _context.OpportunityDocuments.Add(opportunityDocument);
                await _context.SaveChangesAsync();
                return opportunityDocument.Id;
            }
        }

    }
}

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
    public class DeleteOpportunityDocumentByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int? OpportunityId { get; set; }
        public int? Document { get; set; }

        public class DeleteOpportunityDocumentByIdCommandHandler : IRequestHandler<DeleteOpportunityDocumentByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteOpportunityDocumentByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteOpportunityDocumentByIdCommand command, CancellationToken cancellationToken)
            {
                var opportunityDocument = _context.OpportunityDocuments.Where(a => a.Id == command.Id).FirstOrDefault();
                if (opportunityDocument == null) return default;
                _context.OpportunityDocuments.Remove(opportunityDocument);
                await _context.SaveChangesAsync();
                return opportunityDocument.Id;
            }
        }

    }
}

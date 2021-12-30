using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.OpportunityActionTypeFeatures.Commands
{
    public class CreateOpportunityActionTypeCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int SequenceNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }

        public class CreateOpportunityActionTypeCommandHandler : IRequestHandler<CreateOpportunityActionTypeCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateOpportunityActionTypeCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateOpportunityActionTypeCommand command, CancellationToken cancellationToken)
            {
                var opportunityActionType = new OpportunityActionType();
                opportunityActionType.Id = command.Id;
                opportunityActionType.SequenceNumber = command.SequenceNumber;
                opportunityActionType.Title = command.Title;
                opportunityActionType.Description = command.Description;
                opportunityActionType.Note = command.Note;

                _context.OpportunityActionTypes.Add(opportunityActionType);
                await _context.SaveChangesAsync();
                return opportunityActionType.Id;
            }
        }

    }
}

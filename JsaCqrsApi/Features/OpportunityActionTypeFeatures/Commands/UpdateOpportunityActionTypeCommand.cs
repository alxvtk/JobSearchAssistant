using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.OpportunityActionTypeFeatures.Commands
{
    public class UpdateOpportunityActionTypeCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int SequenceNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }

        public class UpdateOpportunityActionTypeCommandHandler : IRequestHandler<UpdateOpportunityActionTypeCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdateOpportunityActionTypeCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateOpportunityActionTypeCommand command, CancellationToken cancellationToken)
            {
                var opportunityActionType = _context.OpportunityActionTypes.Where(a => a.Id == command.Id).FirstOrDefault();
                if (opportunityActionType == null)
                {
                    return default;
                }
                else
                {
                    opportunityActionType.SequenceNumber = command.SequenceNumber;
                    opportunityActionType.Title = command.Title;
                    opportunityActionType.Description = command.Description;
                    opportunityActionType.Note = command.Note;
                    await _context.SaveChangesAsync();
                    return opportunityActionType.Id;
                }
            }

        }


    }
}

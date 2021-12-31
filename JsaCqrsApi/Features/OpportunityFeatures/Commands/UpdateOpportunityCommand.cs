using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.OpportunityFeatures.Commands
{
    public class UpdateOpportunityCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int JobDescriptionId { get; set; }
        public int ResumeId { get; set; }
        public string Active { get; set; }

        public class UpdateOpportunityCommandHandler : IRequestHandler<UpdateOpportunityCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdateOpportunityCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateOpportunityCommand command, CancellationToken cancellationToken)
            {
                var opportunity = _context.Opportunities.Where(a => a.Id == command.Id).FirstOrDefault();
                if (opportunity == null)
                {
                    return default;
                }
                else
                {
                    opportunity.JobDescriptionId = command.JobDescriptionId;
                    opportunity.ResumeId = command.ResumeId;
                    opportunity.Active = command.Active;
                    await _context.SaveChangesAsync();
                    return opportunity.Id;
                }
            }

        }


    }
}

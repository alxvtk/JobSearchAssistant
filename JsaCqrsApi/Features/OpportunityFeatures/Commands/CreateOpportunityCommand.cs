using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.OpportunityFeatures.Commands
{
    public class CreateOpportunityCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int JobDescriptionId { get; set; }
        public int ResumeId { get; set; }
        public string Active { get; set; }

        public class CreateOpportunityCommandHandler : IRequestHandler<CreateOpportunityCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateOpportunityCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateOpportunityCommand command, CancellationToken cancellationToken)
            {
                var opportunity = new Opportunity();
                opportunity.Id = command.Id;
                opportunity.JobDescriptionId = command.JobDescriptionId;
                opportunity.ResumeId = command.ResumeId;
                opportunity.Active = command.Active;

                _context.Opportunities.Add(opportunity);
                await _context.SaveChangesAsync();
                return opportunity.Id;
            }
        }

    }
}

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
    public class DeleteOpportunityByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int JobDescriptionId { get; set; }
        public int ResumeId { get; set; }
        public string Active { get; set; }

        public class DeleteOpportunityByIdCommandHandler : IRequestHandler<DeleteOpportunityByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteOpportunityByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteOpportunityByIdCommand command, CancellationToken cancellationToken)
            {
                var opportunity = _context.Opportunities.Where(a => a.Id == command.Id).FirstOrDefault();
                if (opportunity == null) return default;
                _context.Opportunities.Remove(opportunity);
                await _context.SaveChangesAsync();
                return opportunity.Id;
            }
        }

    }
}

using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.JobDescriptionFeatures.Commands
{
    public class UpdateJobDescriptionCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public int DocumentId { get; set; }

        public class UpdateJobDescriptionCommandHandler : IRequestHandler<UpdateJobDescriptionCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdateJobDescriptionCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateJobDescriptionCommand command, CancellationToken cancellationToken)
            {
                var jobDescription = _context.JobDescriptions.Where(a => a.Id == command.Id).FirstOrDefault();
                if (jobDescription == null)
                {
                    return default;
                }
                else
                {
                    jobDescription.SourceId = command.SourceId;
                    jobDescription.DocumentId = command.DocumentId;
                    await _context.SaveChangesAsync();
                    return jobDescription.Id;
                }
            }

        }


    }
}

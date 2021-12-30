using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.JobDescriptionFeatures.Commands
{
    public class CreateJobDescriptionCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public int DocumentId { get; set; }

        public class CreateJobDescriptionCommandHandler : IRequestHandler<CreateJobDescriptionCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateJobDescriptionCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateJobDescriptionCommand command, CancellationToken cancellationToken)
            {
                var jobDescription = new JobDescription();
                jobDescription.Id = command.Id;
                jobDescription.SourceId = command.SourceId;
                jobDescription.DocumentId = command.DocumentId;

                _context.JobDescriptions.Add(jobDescription);
                await _context.SaveChangesAsync();
                return jobDescription.Id;
            }
        }

    }
}

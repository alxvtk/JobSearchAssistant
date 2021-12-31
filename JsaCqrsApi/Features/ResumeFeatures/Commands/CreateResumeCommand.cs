using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.ResumeFeatures.Commands
{
    public class CreateResumeCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public int Version { get; set; }
        public int? SubVersion { get; set; }
        public DateTime VersioningDate { get; set; }
        public string Active { get; set; }

        public class CreateResumeCommandHandler : IRequestHandler<CreateResumeCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateResumeCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateResumeCommand command, CancellationToken cancellationToken)
            {
                var resume = new Resume();
                resume.Id = command.Id;
                resume.DocumentId = command.DocumentId;
                resume.Version =  command.Version;
                resume.SubVersion =  command.SubVersion;
                resume.VersioningDate = command.VersioningDate;
                resume.Active =  command.Active;

                _context.Resumes.Add(resume);
                await _context.SaveChangesAsync();
                return resume.Id;
            }
        }

    }
}

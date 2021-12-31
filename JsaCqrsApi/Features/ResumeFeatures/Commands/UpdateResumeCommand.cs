using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.ResumeFeatures.Commands
{
    public class UpdateResumeCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public int Version { get; set; }
        public int? SubVersion { get; set; }
        public DateTime VersioningDate { get; set; }
        public string Active { get; set; }

        public class UpdateResumeCommandHandler : IRequestHandler<UpdateResumeCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdateResumeCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateResumeCommand command, CancellationToken cancellationToken)
            {
                var resume = _context.Resumes.Where(a => a.Id == command.Id).FirstOrDefault();
                if (resume == null)
                {
                    return default;
                }
                else
                {
                    resume.DocumentId = command.DocumentId;
                    resume.Version = command.Version;
                    resume.SubVersion = command.SubVersion;
                    resume.VersioningDate = command.VersioningDate;
                    resume.Active = command.Active;
                    await _context.SaveChangesAsync();
                    return resume.Id;
                }
            }

        }


    }
}

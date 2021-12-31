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
    public class DeleteResumeByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public int Version { get; set; }
        public int? SubVersion { get; set; }
        public DateTime VersioningDate { get; set; }
        public string Active { get; set; }

        public class DeleteResumeByIdCommandHandler : IRequestHandler<DeleteResumeByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteResumeByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteResumeByIdCommand command, CancellationToken cancellationToken)
            {
                var resume = _context.Resumes.Where(a => a.Id == command.Id).FirstOrDefault();
                if (resume == null) return default;
                _context.Resumes.Remove(resume);
                await _context.SaveChangesAsync();
                return resume.Id;
            }
        }

    }
}

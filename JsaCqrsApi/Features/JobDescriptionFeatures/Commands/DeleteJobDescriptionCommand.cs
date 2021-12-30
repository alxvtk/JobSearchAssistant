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
    public class DeleteJobDescriptionByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public int DocumentId { get; set; }

        public class DeleteJobDescriptionByIdCommandHandler : IRequestHandler<DeleteJobDescriptionByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteJobDescriptionByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteJobDescriptionByIdCommand command, CancellationToken cancellationToken)
            {
                var jobDescription = _context.JobDescriptions.Where(a => a.Id == command.Id).FirstOrDefault();
                if (jobDescription == null) return default;
                _context.JobDescriptions.Remove(jobDescription);
                await _context.SaveChangesAsync();
                return jobDescription.Id;
            }
        }

    }
}

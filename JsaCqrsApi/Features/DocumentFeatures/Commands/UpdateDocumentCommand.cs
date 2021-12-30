using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.DocumentFeatures.Commands
{
    public class UpdateDocumentCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int? UrLinklId { get; set; }
        public int? EmailId { get; set; }
        public int? DocFormatId { get; set; }
        public string Body { get; set; }
        public string FullPath { get; set; }

        public class UpdateDocumentCommandHandler : IRequestHandler<UpdateDocumentCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdateDocumentCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateDocumentCommand command, CancellationToken cancellationToken)
            {
                var document = _context.Documents.Where(a => a.Id == command.Id).FirstOrDefault();
                if (document == null)
                {
                    return default;
                }
                else
                {
                    document.UrLinklId = command.UrLinklId;
                    document.EmailId = command.EmailId;
                    document.DocFormatId = command.DocFormatId;
                    document.Body = command.Body;
                    document.FullPath = command.FullPath;
                    await _context.SaveChangesAsync();
                    return document.Id;
                }
            }

        }


    }
}

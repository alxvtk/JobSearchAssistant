using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.DocumentFeatures.Commands
{
    public class CreateDocumentCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int? UrLinklId { get; set; }
        public int? EmailId { get; set; }
        public int? DocFormatId { get; set; }
        public string Body { get; set; }
        public string FullPath { get; set; }

        public class CreateDocumentCommandHandler : IRequestHandler<CreateDocumentCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateDocumentCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateDocumentCommand command, CancellationToken cancellationToken)
            {
                var document = new Document();
                document.Id = command.Id;
                document.UrLinklId = command.UrLinklId;
                document.EmailId = command.EmailId;
                document.DocFormatId = command.DocFormatId;
                document.Body = command.Body;
                document.FullPath = command.FullPath;

                _context.Documents.Add(document);
                await _context.SaveChangesAsync();
                return document.Id;
            }
        }

    }
}

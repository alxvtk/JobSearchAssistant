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
    public class DeleteDocumentByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int? UrLinklId { get; set; }
        public int? EmailId { get; set; }
        public int? DocFormatId { get; set; }
        public string Body { get; set; }
        public string FullPath { get; set; }

        public class DeleteDocumentByIdCommandHandler : IRequestHandler<DeleteDocumentByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteDocumentByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteDocumentByIdCommand command, CancellationToken cancellationToken)
            {
                var document = _context.Documents.Where(a => a.Id == command.Id).FirstOrDefault();
                if (document == null) return default;
                _context.Documents.Remove(document);
                await _context.SaveChangesAsync();
                return document.Id;
            }
        }

    }
}

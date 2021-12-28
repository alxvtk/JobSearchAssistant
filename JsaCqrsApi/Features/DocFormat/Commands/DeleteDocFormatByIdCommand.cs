using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.DocFormatFeatures.Commands
{
    public class DeleteDocFormatByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public class DeleteDocFormatByIdCommandHandler : IRequestHandler<DeleteDocFormatByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteDocFormatByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteDocFormatByIdCommand command, CancellationToken cancellationToken)
            {
                var docFormat = _context.DocFormats.Where(a => a.Id == command.Id).FirstOrDefault();
                if (docFormat == null) return default;
                _context.DocFormats.Remove(docFormat);
                await _context.SaveChangesAsync();
                return docFormat.Id;
            }
        }

    }
}

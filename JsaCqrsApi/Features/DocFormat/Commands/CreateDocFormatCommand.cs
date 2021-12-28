using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.DocFormatFeatures.Commands
{
    public class CreateDocFormatCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public class CreateDocFormatCommandHandler : IRequestHandler<CreateDocFormatCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateDocFormatCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateDocFormatCommand command, CancellationToken cancellationToken)
            {
                var docFormat = new DocFormat();
                docFormat.Id = command.Id;
                docFormat.Type = command.Type;

                _context.DocFormats.Add(docFormat);
                await _context.SaveChangesAsync();
                return docFormat.Id;
            }
        }

    }
}

using JsaCqrsApi.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.SourceTypeFeatures.Commands
{
    public class DeleteJsaSourceTypeByIdCommand : IRequest<int>
    {
        public int Id { get; set; }

        public class DeleteSourceTypeByIdCommandHandler: IRequestHandler<DeleteJsaSourceTypeByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteSourceTypeByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteJsaSourceTypeByIdCommand command, CancellationToken cancellationToken)
            {
                var jsaSourceType = await _context.JsaSourceType.Where(a => a.Id == command.Id).FirstOrDefaultAsync();
                if (jsaSourceType == null) return default;
                _context.JsaSourceType.Remove(jsaSourceType);
                await _context.SaveChanges();
                return jsaSourceType.Id;
            }
        }
    }
}

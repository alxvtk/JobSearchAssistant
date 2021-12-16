using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.JsaSourceTypeFeatures.Commands
{
    public class DeleteJsaSourceTypeByIdCommand : IRequest<int>
    {
        public  int Id { get; set; }
        public string StType { get; set; }
        public string StTypeName { get; set; }

        public class DeleteJsaSourceTypeByIdCommandHandler : IRequestHandler<DeleteJsaSourceTypeByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteJsaSourceTypeByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteJsaSourceTypeByIdCommand command, CancellationToken cancellationToken)
            {
                var jsaSourceType = _context.JsaSourceTypes.Where(a => a.StId == command.Id).FirstOrDefault();
                if (jsaSourceType == null) return default;
                _context.JsaSourceTypes.Remove(jsaSourceType);
                await _context.SaveChangesAsync();
                return jsaSourceType.StId;
            }
        }

    }
}

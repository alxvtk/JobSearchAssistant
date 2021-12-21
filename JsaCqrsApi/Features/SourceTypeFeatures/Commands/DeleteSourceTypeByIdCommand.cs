using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.SourceTypeFeatures.Commands
{
    public class DeleteSourceTypeByIdCommand : IRequest<int>
    {
        public  int Id { get; set; }
        public string StType { get; set; }
        public string StTypeName { get; set; }

        public class DeleteSourceTypeByIdCommandHandler : IRequestHandler<DeleteSourceTypeByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteSourceTypeByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteSourceTypeByIdCommand command, CancellationToken cancellationToken)
            {
                var SourceType = _context.SourceTypes.Where(a => a.StId == command.Id).FirstOrDefault();
                if (SourceType == null) return default;
                _context.SourceTypes.Remove(SourceType);
                await _context.SaveChangesAsync();
                return SourceType.StId;
            }
        }

    }
}

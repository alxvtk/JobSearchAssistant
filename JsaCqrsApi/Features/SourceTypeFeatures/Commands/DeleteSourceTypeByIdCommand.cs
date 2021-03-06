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
        public string TypeValue { get; set; }
        public string TypeName { get; set; }

        public class DeleteSourceTypeByIdCommandHandler : IRequestHandler<DeleteSourceTypeByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteSourceTypeByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteSourceTypeByIdCommand command, CancellationToken cancellationToken)
            {
                var sourceType = _context.SourceTypes.Where(a => a.Id == command.Id).FirstOrDefault();
                if (sourceType == null) return default;
                _context.SourceTypes.Remove(sourceType);
                await _context.SaveChangesAsync();
                return sourceType.Id;
            }
        }

    }
}

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
    public class UpdateSourceTypeCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string TypeValue { get; set; }
        public string TypeName { get; set; }

        public class UpdateSourceTypeCommandHandler : IRequestHandler<UpdateSourceTypeCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdateSourceTypeCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateSourceTypeCommand command, CancellationToken cancellationToken)
            {
                var sourceType = _context.SourceTypes.Where(a => a.Id == command.Id).FirstOrDefault();
                if (sourceType == null)
                {
                    return default;
                }
                else
                {
                    sourceType.Type = command.TypeValue;
                    sourceType.TypeName = command.TypeName;
                    await _context.SaveChangesAsync();
                    return sourceType.Id;
                }
            }

        }


    }
}

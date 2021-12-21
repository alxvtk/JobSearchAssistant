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
        public string StType { get; set; }
        public string StTypeName { get; set; }

        public class UpdateSourceTypeCommandHandler : IRequestHandler<UpdateSourceTypeCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdateSourceTypeCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateSourceTypeCommand command, CancellationToken cancellationToken)
            {
                var SourceType = _context.SourceTypes.Where(a => a.StId == command.Id).FirstOrDefault();
                if (SourceType == null)
                {
                    return default;
                }
                else
                {
                    SourceType.StType = command.StType;
                    SourceType.StTypeName = command.StTypeName;
                    await _context.SaveChangesAsync();
                    return SourceType.StId;
                }
            }

        }


    }
}

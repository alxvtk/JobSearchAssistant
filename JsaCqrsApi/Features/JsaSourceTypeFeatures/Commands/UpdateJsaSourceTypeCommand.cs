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
    public class UpdateJsaSourceTypeCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string StType { get; set; }
        public string StTypeName { get; set; }

        public class UpdateJsaSourceTypeCommandHandler : IRequestHandler<UpdateJsaSourceTypeCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdateJsaSourceTypeCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateJsaSourceTypeCommand command, CancellationToken cancellationToken)
            {
                var jsaSourceType = _context.JsaSourceTypes.Where(a => a.StId == command.Id).FirstOrDefault();
                if (jsaSourceType == null)
                {
                    return default;
                }
                else
                {
                    jsaSourceType.StType = command.StType;
                    jsaSourceType.StTypeName = command.StTypeName;
                    await _context.SaveChangesAsync();
                    return jsaSourceType.StId;
                }
            }

        }


    }
}

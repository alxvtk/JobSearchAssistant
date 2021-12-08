using JsaCqrsApi.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.SourceTypeFeatures.Commands
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
                var jsaSourceType = _context.JsaSourceType.Where(a => a.Id == command.Id).FirstOrDefault();
                if (jsaSourceType == null)
                {
                    return default;
                }
                else
                {
                    jsaSourceType.StType = command.StType;
                    jsaSourceType.StTypeName = command.StTypeName;
                    await _context.SaveChanges();
                    return jsaSourceType.Id;
                }
            }
        }


    }
}

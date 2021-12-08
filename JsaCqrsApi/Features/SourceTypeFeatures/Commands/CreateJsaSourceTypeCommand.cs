using JsaCqrsApi.Context;
using JsaCqrsApi.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.SourceTypeFeatures.Commands
{
    public class CreateJsaSourceTypeCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string StType { get; set; }
        public string StTypeName { get; set; }

        public class CreateJsaSourceTypeCommandHandler : IRequestHandler<CreateJsaSourceTypeCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateJsaSourceTypeCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateJsaSourceTypeCommand command, CancellationToken cancellationToken)
            {
                var jsaSourceType = new JsaSourceType();
                jsaSourceType.StType = command.StType;
                jsaSourceType.StTypeName = command.StTypeName;
                //jsaSourceType
                _context.JsaSourceType.Add(jsaSourceType);
                await _context.SaveChanges();
                return jsaSourceType.Id;

            }
        }
    }

}

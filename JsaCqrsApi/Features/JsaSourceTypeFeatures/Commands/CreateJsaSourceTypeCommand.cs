using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.JsaSourceTypeFeatures.Commands
{
    public class CreateJsaSourceTypeCommand : IRequest<int>
    {
        public int StId { get; set; }
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
                var jsaSourseType = new JsaSourceType();
                jsaSourseType.StId = command.StId;
                jsaSourseType.StType = command.StType;
                jsaSourseType.StTypeName = command.StTypeName;

                _context.JsaSourceTypes.Add(jsaSourseType);
                await _context.SaveChangesAsync();
                return jsaSourseType.StId;
            }
        }

    }
}

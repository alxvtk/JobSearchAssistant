using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.SourceTypeFeatures.Commands
{
    public class CreateSourceTypeCommand : IRequest<int>
    {
        public int StId { get; set; }
        public string StType { get; set; }
        public string StTypeName { get; set; }

        public class CreateSourceTypeCommandHandler : IRequestHandler<CreateSourceTypeCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateSourceTypeCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateSourceTypeCommand command, CancellationToken cancellationToken)
            {
                var jsaSourseType = new SourceType();
                jsaSourseType.StId = command.StId;
                jsaSourseType.StType = command.StType;
                jsaSourseType.StTypeName = command.StTypeName;

                _context.SourceTypes.Add(jsaSourseType);
                await _context.SaveChangesAsync();
                return jsaSourseType.StId;
            }
        }

    }
}

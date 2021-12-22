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
        public int Id { get; set; }
        public string TypeValue { get; set; }
        public string TypeName { get; set; }

        public class CreateSourceTypeCommandHandler : IRequestHandler<CreateSourceTypeCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateSourceTypeCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateSourceTypeCommand command, CancellationToken cancellationToken)
            {
                var sourseType = new SourceType();
                sourseType.Id = command.Id;
                sourseType.Type = command.TypeValue;
                sourseType.TypeName = command.TypeName;

                _context.SourceTypes.Add(sourseType);
                await _context.SaveChangesAsync();
                return sourseType.Id;
            }
        }

    }
}

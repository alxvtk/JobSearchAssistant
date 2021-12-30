using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.ResultStatusFeatures.Commands
{
    public class CreateResultStatusCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CategoryId { get; set; }

        public class CreateResultStatusCommandHandler : IRequestHandler<CreateResultStatusCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateResultStatusCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateResultStatusCommand command, CancellationToken cancellationToken)
            {
                var resultStatus = new JsaCqrsApi.Domain.Models.ResultStatus();
                resultStatus.Id = command.Id;
                resultStatus.Name = command.Name;
                resultStatus.Code = command.Code;
                resultStatus.CategoryId = command.CategoryId;

                _context.ResultStatuses.Add(resultStatus);
                await _context.SaveChangesAsync();
                return resultStatus.Id;
            }
        }

    }
}

using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.ResultStatusFeatures.Commands
{
    public class UpdateResultStatusCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CategoryId { get; set; }

        public class UpdateResultStatusCommandHandler : IRequestHandler<UpdateResultStatusCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdateResultStatusCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateResultStatusCommand command, CancellationToken cancellationToken)
            {
                var resultStatus = _context.ResultStatuses.Where(a => a.Id == command.Id).FirstOrDefault();
                if (resultStatus == null)
                {
                    return default;
                }
                else
                {
                    resultStatus.Name = command.Name;
                    resultStatus.Code = command.Code;
                    resultStatus.CategoryId = command.CategoryId;
                    await _context.SaveChangesAsync();
                    return resultStatus.Id;
                }
            }

        }


    }
}

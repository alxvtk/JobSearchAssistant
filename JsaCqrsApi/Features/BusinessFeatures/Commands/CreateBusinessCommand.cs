using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.BusinessFeatures.Commands
{
    public class CreateBusinessCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public class CreateBusinessCommandHandler : IRequestHandler<CreateBusinessCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateBusinessCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateBusinessCommand command, CancellationToken cancellationToken)
            {
                var business = new Business();
                business.Id = command.Id;
                business.Name = command.Name;

                _context.Businesses.Add(business);
                await _context.SaveChangesAsync();
                return business.Id;
            }
        }

    }
}

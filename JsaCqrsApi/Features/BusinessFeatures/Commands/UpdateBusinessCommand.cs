using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.BusinessFeatures.Commands
{
    public class UpdateBusinessCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public class UpdateBusinessCommandHandler : IRequestHandler<UpdateBusinessCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdateBusinessCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateBusinessCommand command, CancellationToken cancellationToken)
            {
                var business = _context.Businesses.Where(a => a.Id == command.Id).FirstOrDefault();
                if (business == null)
                {
                    return default;
                }
                else
                {
                    business.Name = command.Name;
                    await _context.SaveChangesAsync();
                    return business.Id;
                }
            }

        }


    }
}

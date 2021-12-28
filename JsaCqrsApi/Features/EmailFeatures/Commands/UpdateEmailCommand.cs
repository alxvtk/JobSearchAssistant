using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.EmailFeatures.Commands
{
    public class UpdateEmailCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }

        public class UpdateEmailCommandHandler : IRequestHandler<UpdateEmailCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdateEmailCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateEmailCommand command, CancellationToken cancellationToken)
            {
                var email = _context.Emails.Where(a => a.Id == command.Id).FirstOrDefault();
                if (email == null)
                {
                    return default;
                }
                else
                {
                    email.Address = command.Address;
                    email.Comment = command.Comment;
                    await _context.SaveChangesAsync();
                    return email.Id;
                }
            }

        }


    }
}

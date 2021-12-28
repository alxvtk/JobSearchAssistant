using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.EmailFeatures.Commands
{
    public class CreateEmailCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }

        public class CreateEmailCommandHandler : IRequestHandler<CreateEmailCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateEmailCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateEmailCommand command, CancellationToken cancellationToken)
            {
                var email = new Email();
                email.Id = command.Id;
                email.Address = command.Address;
                email.Comment = command.Comment;

                _context.Emails.Add(email);
                await _context.SaveChangesAsync();
                return email.Id;
            }
        }

    }
}

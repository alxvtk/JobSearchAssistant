using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.UserFeatures.Commands
{
    public class CreateUserCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int PersonId { get; set; }

        public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateUserCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateUserCommand command, CancellationToken cancellationToken)
            {
                var user = new User();
                user.Id = command.Id;
                user.PersonId = command.PersonId;

                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return user.Id;
            }
        }

    }
}

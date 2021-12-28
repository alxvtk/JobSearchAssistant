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
    public class DeleteEmailByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }

        public class DeleteEmailByIdCommandHandler : IRequestHandler<DeleteEmailByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteEmailByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteEmailByIdCommand command, CancellationToken cancellationToken)
            {
                var email = _context.Emails.Where(a => a.Id == command.Id).FirstOrDefault();
                if (email == null) return default;
                _context.Emails.Remove(email);
                await _context.SaveChangesAsync();
                return email.Id;
            }
        }

    }
}

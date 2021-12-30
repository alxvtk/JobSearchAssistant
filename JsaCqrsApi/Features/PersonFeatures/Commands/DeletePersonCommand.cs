using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.PersonFeatures.Commands
{
    public class DeletePersonByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string Comments { get; set; }

        public class DeletePersonByIdCommandHandler : IRequestHandler<DeletePersonByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeletePersonByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeletePersonByIdCommand command, CancellationToken cancellationToken)
            {
                var person = _context.Persons.Where(a => a.Id == command.Id).FirstOrDefault();
                if (person == null) return default;
                _context.Persons.Remove(person);
                await _context.SaveChangesAsync();
                return person.Id;
            }
        }

    }
}

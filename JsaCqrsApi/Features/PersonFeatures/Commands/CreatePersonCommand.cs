using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.PersonFeatures.Commands
{
    public class CreatePersonCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string Comments { get; set; }

        public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreatePersonCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreatePersonCommand command, CancellationToken cancellationToken)
            {
                var person = new Person();
                person.Id = command.Id;
                person.FirstName = command.FirstName;
                person.LastName = command.LastName;
                person.NickName = command.NickName;
                person.Title = command.Title;
                person.Position = command.Position;
                person.Comments = command.Comments;

                _context.Persons.Add(person);
                await _context.SaveChangesAsync();
                return person.Id;
            }
        }

    }
}

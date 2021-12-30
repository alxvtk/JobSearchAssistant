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
    public class UpdatePersonCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string Comments { get; set; }

        public class UpdatePersonCommandHandler : IRequestHandler<UpdatePersonCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdatePersonCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdatePersonCommand command, CancellationToken cancellationToken)
            {
                var person = _context.Persons.Where(a => a.Id == command.Id).FirstOrDefault();
                if (person == null)
                {
                    return default;
                }
                else
                {
                    person.FirstName = command.FirstName;
                    person.LastName = command.LastName;
                    person.NickName = command.NickName;
                    person.Title = command.Title;
                    person.Position = command.Position;
                    person.Comments = command.Comments;

                    await _context.SaveChangesAsync();
                    return person.Id;
                }
            }

        }


    }
}

using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.PhoneFeatures.Commands
{
    public class CreatePhoneCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Fax { get; set; }
        public string Comment { get; set; }

        public class CreatePhoneCommandHandler : IRequestHandler<CreatePhoneCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreatePhoneCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreatePhoneCommand command, CancellationToken cancellationToken)
            {
                var phone = new Phone();
                phone.Id = command.Id;
                phone.Number = command.Number;
                phone.Name = command.Name;
                phone.Fax = command.Fax;
                phone.Comment = command.Comment;

                _context.Phones.Add(phone);
                await _context.SaveChangesAsync();
                return phone.Id;
            }
        }

    }
}

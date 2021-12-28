using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.PhoneFeatures.Commands
{
    public class UpdatePhoneCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Fax { get; set; }
        public string Comment { get; set; }

        public class UpdatePhoneCommandHandler : IRequestHandler<UpdatePhoneCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdatePhoneCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdatePhoneCommand command, CancellationToken cancellationToken)
            {
                var phone = _context.Phones.Where(a => a.Id == command.Id).FirstOrDefault();
                if (phone == null)
                {
                    return default;
                }
                else
                {
                    phone.Number = command.Number;
                    phone.Name = command.Name;
                    phone.Fax = command.Fax;
                    phone.Comment = command.Comment;
                    await _context.SaveChangesAsync();
                    return phone.Id;
                }
            }

        }


    }
}

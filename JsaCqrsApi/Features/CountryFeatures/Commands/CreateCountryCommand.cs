using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.CountryFeatures.Commands
{
    public class CreateCountryCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateCountryCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateCountryCommand command, CancellationToken cancellationToken)
            {
                var country = new Country();
                country.Id = command.Id;
                country.Name = command.Name;
                country.Code = command.Code;

                _context.Countries.Add(country);
                await _context.SaveChangesAsync();
                return country.Id;
            }
        }

    }
}

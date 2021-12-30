using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

//namespace JsaCqrsApi.Features.CountryFeatures.Commands
namespace JsaCqrsApi.Application.Features.CountryFeatures.Commands
{
    public class UpdateCountryCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdateCountryCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateCountryCommand command, CancellationToken cancellationToken)
            {
                var country = _context.Countries.Where(a => a.Id == command.Id).FirstOrDefault();
                if (country == null)
                {
                    return default;
                }
                else
                {
                    country.Name = command.Name;
                    country.Code = command.Code;
                    await _context.SaveChangesAsync();
                    return country.Id;
                }
            }

        }


    }
}

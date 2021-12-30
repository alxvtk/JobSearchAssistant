using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.CountryFeatures.Commands
{
    public class DeleteCountryByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public class DeleteCountryByIdCommandHandler : IRequestHandler<DeleteCountryByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteCountryByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteCountryByIdCommand command, CancellationToken cancellationToken)
            {
                var country = _context.Countries.Where(a => a.Id == command.Id).FirstOrDefault();
                if (country == null) return default;
                _context.Countries.Remove(country);
                await _context.SaveChangesAsync();
                return country.Id;
            }
        }

    }
}

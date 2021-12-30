using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.LocationFeatures.Commands
{
    public class DeleteLocationByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string StreetNumber { get; set; }
        public string StreetNumberSuffix { get; set; }
        public string StreetName { get; set; }
        public string StreetType { get; set; }
        public string StreetDirection { get; set; }
        public string Unit { get; set; }
        public string Municipality { get; set; }
        public string Province { get; set; }
        public int CountryId { get; set; }
        public string PostalCode { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string Comments { get; set; }

        public class DeleteLocationByIdCommandHandler : IRequestHandler<DeleteLocationByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteLocationByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteLocationByIdCommand command, CancellationToken cancellationToken)
            {
                var location = _context.Locations.Where(a => a.Id == command.Id).FirstOrDefault();
                if (location == null) return default;
                _context.Locations.Remove(location);
                await _context.SaveChangesAsync();
                return location.Id;
            }
        }

    }
}

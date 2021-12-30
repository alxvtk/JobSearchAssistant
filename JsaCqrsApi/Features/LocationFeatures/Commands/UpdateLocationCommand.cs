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
    public class UpdateLocationCommand : IRequest<int>
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

        public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdateLocationCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateLocationCommand command, CancellationToken cancellationToken)
            {
                var location = _context.Locations.Where(a => a.Id == command.Id).FirstOrDefault();
                if (location == null)
                {
                    return default;
                }
                else
                {
                    location.StreetNumber = command.StreetNumber;
                    location.StreetNumber = command.StreetNumber;
                    location.StreetNumberSuffix = command.StreetNumberSuffix;
                    location.StreetName = command.StreetName;
                    location.StreetType = command.StreetType;
                    location.StreetDirection = command.StreetDirection;
                    location.Unit = command.Unit;
                    location.Municipality = command.Municipality;
                    location.Province = command.Province;
                    location.CountryId = command.CountryId;
                    location.PostalCode = command.PostalCode;
                    location.StreetLine1 = command.StreetLine1;
                    location.StreetLine2 = command.StreetLine2;
                    location.Comments = command.Comments;

                    await _context.SaveChangesAsync();
                    return location.Id;
                }
            }

        }


    }
}

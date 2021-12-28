using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.PhoneFeatures.Queries
{
    public class GetAllPhonesQuery : IRequest<IEnumerable<Phone>>
    {
        public class GetAllPhonesQureyHandler : IRequestHandler<GetAllPhonesQuery, IEnumerable<Phone>>
        {
            private readonly IApplicationContext _context;
            public GetAllPhonesQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Phone>> Handle(GetAllPhonesQuery request, CancellationToken cancellationToken)
            {
                var phone = await _context.Phones.ToListAsync();
                if (phone == null)
                {
                    return null;
                }
                return phone.AsReadOnly();
            }
        }
    }
}

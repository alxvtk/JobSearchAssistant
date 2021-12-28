using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.PhoneFeatures.Queries
{
    public class GetPhoneByIdQuery : IRequest<Phone>
    {
        public int Id { get; set; }
        public class GetPhoneByIdQueryHandler : IRequestHandler<GetPhoneByIdQuery, Phone>
        {
            private readonly IApplicationContext _context;
            public GetPhoneByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<Phone> Handle(GetPhoneByIdQuery query, CancellationToken cancellationToken)
            {
                var phone = _context.Phones.Where(a => a.Id == query.Id).FirstOrDefault();
                if (phone == null) return null;
                return phone;
            }
        }


    }
}

using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.BusinessFeatures.Queries
{
    public class GetBusinessByIdQuery : IRequest<Business>
    {
        public int Id { get; set; }
        public class GetBusinessByIdQueryHandler : IRequestHandler<GetBusinessByIdQuery, Business>
        {
            private readonly IApplicationContext _context;
            public GetBusinessByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<Business> Handle(GetBusinessByIdQuery query, CancellationToken cancellationToken)
            {
                var business = _context.Businesses.Where(a => a.Id == query.Id).FirstOrDefault();
                if (business == null) return null;
                return business;
            }
        }

    }
}

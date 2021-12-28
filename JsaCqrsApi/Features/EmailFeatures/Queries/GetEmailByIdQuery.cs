using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.EmailFeatures.Queries
{
    public class GetEmailByIdQuery : IRequest<Email>
    {
        public int Id { get; set; }
        public class GetEmailByIdQueryHandler : IRequestHandler<GetEmailByIdQuery, Email>
        {
            private readonly IApplicationContext _context;
            public GetEmailByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<Email> Handle(GetEmailByIdQuery query, CancellationToken cancellationToken)
            {
                var email = _context.Emails.Where(a => a.Id == query.Id).FirstOrDefault();
                if (email == null) return null;
                return email;
            }
        }


    }
}

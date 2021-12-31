using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.UserFeatures.Queries
{
    public class GetUserByIdQuery : IRequest<User>
    {
        public int Id { get; set; }
        public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, User>
        {
            private readonly IApplicationContext _context;
            public GetUserByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<User> Handle(GetUserByIdQuery query, CancellationToken cancellationToken)
            {
                var user = _context.Users.Where(a => a.Id == query.Id).FirstOrDefault();
                if (user == null) return null;
                return user;
            }
        }

    }
}

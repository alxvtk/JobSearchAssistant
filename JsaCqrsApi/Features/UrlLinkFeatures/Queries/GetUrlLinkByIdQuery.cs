using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.UrlLinkFeatures.Queries
{
    public class GetUrlLinkByIdQuery : IRequest<UrlLink>
    {
        public int Id { get; set; }
        public class GetUrlLinkByIdQueryHandler : IRequestHandler<GetUrlLinkByIdQuery, UrlLink>
        {
            private readonly IApplicationContext _context;
            public GetUrlLinkByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<UrlLink> Handle(GetUrlLinkByIdQuery query, CancellationToken cancellationToken)
            {
                var urlLink = _context.UrlLinks.Where(a => a.Id == query.Id).FirstOrDefault();
                if (urlLink == null) return null;
                return urlLink;
            }
        }
        

    }
}

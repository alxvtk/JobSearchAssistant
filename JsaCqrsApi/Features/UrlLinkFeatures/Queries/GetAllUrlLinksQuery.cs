using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.UrlLinkFeatures.Queries
{
    public class GetAllUrlLinksQuery : IRequest<IEnumerable<UrlLink>>
    {
        public class GetAllUrlLinksQureyHandler : IRequestHandler<GetAllUrlLinksQuery, IEnumerable<UrlLink>>
        {
            private readonly IApplicationContext _context;
            public GetAllUrlLinksQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<UrlLink>> Handle(GetAllUrlLinksQuery request, CancellationToken cancellationToken)
            {
                var urlListList = await _context.UrlLinks.ToListAsync();
                if (urlListList == null)
                {
                    return null;
                }
                return urlListList.AsReadOnly();
            }
        }
    }
}
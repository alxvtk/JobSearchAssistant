using JsaCqrsApi.Infrastructure.Context;
using JsaCqrsApi.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.SourceFeatures.Queries
{
    public class GetAllSourcesQuery : IRequest<IEnumerable<Source>>
    {
        public class GetAllSourcesQureyHandler : IRequestHandler<GetAllSourcesQuery, IEnumerable<Source>>
        {
            private readonly IApplicationContext _context;
            public GetAllSourcesQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Source>> Handle(GetAllSourcesQuery request, CancellationToken cancellationToken)
            {
                var sourceList = await _context.Sources.ToListAsync();
                if (sourceList == null)
                {
                    return null;
                }
                return sourceList.AsReadOnly();
            }
        }
    }
}

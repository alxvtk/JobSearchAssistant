using JsaCqrsApi.Infrastructure.Context;
using JsaCqrsApi.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.SourceTypeFeatures.Queries
{
    public class GetAllSourceTypesQuery : IRequest<IEnumerable<SourceType>>
    {
        public class GetAllSourceTypesQureyHandler : IRequestHandler<GetAllSourceTypesQuery, IEnumerable<SourceType>>
        {
            private readonly IApplicationContext _context;
            public GetAllSourceTypesQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<SourceType>> Handle(GetAllSourceTypesQuery request, CancellationToken cancellationToken)
            {
                var sourceTypeList = await _context.SourceTypes.ToListAsync();
                if (sourceTypeList == null)
                {
                    return null;
                }
                return sourceTypeList.AsReadOnly();
            }
        }
    }
}

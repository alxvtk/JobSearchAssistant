using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsaCqrsApi.Models;
using JsaCqrsApi.Context;
using System.Threading;
using Microsoft.EntityFrameworkCore;
//using System.Threading.Tasks;

namespace JsaCqrsApi.Features.SourceTypeFeatures.Queries
{
    public class GetAllJsaSourceTypeQuery : IRequest<IEnumerable<JsaSourceType>>
    {
        public class GetAllJsaSourceTypesQueryHandler : IRequestHandler<GetAllJsaSourceTypeQuery, IEnumerable<JsaSourceType>>
        {
            private readonly IApplicationContext _context;
            public GetAllJsaSourceTypesQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<JsaSourceType>> Handle(GetAllJsaSourceTypeQuery request, CancellationToken cancellationToken)
            {
                var jsaSourceTypeList = await _context.JsaSourceType.ToListAsync();
                if (jsaSourceTypeList == null)
                {
                    return null;
                }
                return jsaSourceTypeList.AsReadOnly();
            }
        }

        public class GetJsaSourceTypeByIdQuery : IRequest<JsaSourceType>
        {
            public int Id { get; set; }
            public class GetJsaSourceTypeByIdQueryHandler : IRequestHandler<GetJsaSourceTypeByIdQuery, JsaSourceType>
            {
                private readonly IApplicationContext _context;
                public GetJsaSourceTypeByIdQueryHandler(IApplicationContext context)
                {
                    _context = context;
                }
                public async Task<JsaSourceType> Handle(GetJsaSourceTypeByIdQuery query, CancellationToken cancellationToken)
                {
                    var jsaSourceType = _context.JsaSourceType.Where(a => a.Id == query.Id).FirstOrDefault();
                    if (jsaSourceType == null) return null;
                    return jsaSourceType;
                }
            }
        }
    }
}

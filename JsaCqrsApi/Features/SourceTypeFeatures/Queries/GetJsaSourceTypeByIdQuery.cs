using JsaCqrsApi.Context;
using JsaCqrsApi.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.SourceTypeFeatures.Queries
{
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

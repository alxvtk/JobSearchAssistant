using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.JsaSourceTypeFeatures.Queries
{
    public class GetJsaSourceTypeByIdQurey : IRequest<JsaSourceType>
    {
        public int Id { get; set; }
        public class GetJsaSourceTypeByIdQueryHandler : IRequestHandler<GetJsaSourceTypeByIdQurey, JsaSourceType>
        {
            private readonly IApplicationContext _context;
            public GetJsaSourceTypeByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<JsaSourceType> Handle(GetJsaSourceTypeByIdQurey query, CancellationToken cancellationToken)
            {
                var jsaSourceType = _context.JsaSourceTypes.Where(a => a.StId == query.Id).FirstOrDefault();
                if (jsaSourceType == null) return null;
                return jsaSourceType;
            }
        }
    }
}

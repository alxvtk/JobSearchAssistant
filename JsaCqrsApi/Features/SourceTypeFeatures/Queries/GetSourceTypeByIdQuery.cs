using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.SourceTypeFeatures.Queries
{
    public class GetSourceTypeByIdQuery : IRequest<SourceType>
    {
        public int Id { get; set; }
        public class GetSourceTypeByIdQueryHandler : IRequestHandler<GetSourceTypeByIdQuery, SourceType>
        {
            private readonly IApplicationContext _context;
            public GetSourceTypeByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<SourceType> Handle(GetSourceTypeByIdQuery query, CancellationToken cancellationToken)
            {
                var sourceType = _context.SourceTypes.Where(a => a.Id == query.Id).FirstOrDefault();
                if (sourceType == null) return null;
                return sourceType;
            }
        }

    }
}

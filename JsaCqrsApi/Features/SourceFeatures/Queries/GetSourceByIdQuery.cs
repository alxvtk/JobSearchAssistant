using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.SourceFeatures.Queries
{
    public class GetSourceByIdQuery : IRequest<Source>
    {
        public int Id { get; set; }
        public class GetSourceByIdQueryHandler : IRequestHandler<GetSourceByIdQuery, Source>
        {
            private readonly IApplicationContext _context;
            public GetSourceByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<Source> Handle(GetSourceByIdQuery query, CancellationToken cancellationToken)
            {
                var source = _context.Sources.Where(a => a.Id == query.Id).FirstOrDefault();
                if (source == null) return null;
                return source;
            }
        }

    }
}

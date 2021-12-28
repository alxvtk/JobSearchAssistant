using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.DocFormatFeatures.Queries
{
    public class GetDocFormatByIdQuery : IRequest<DocFormat>
    {
        public int Id { get; set; }
        public class GetDocFormatByIdQueryHandler : IRequestHandler<GetDocFormatByIdQuery, DocFormat>
        {
            private readonly IApplicationContext _context;
            public GetDocFormatByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<DocFormat> Handle(GetDocFormatByIdQuery query, CancellationToken cancellationToken)
            {
                var docFormat = _context.DocFormats.Where(a => a.Id == query.Id).FirstOrDefault();
                if (docFormat == null) return null;
                return docFormat;
            }
        }


    }
}

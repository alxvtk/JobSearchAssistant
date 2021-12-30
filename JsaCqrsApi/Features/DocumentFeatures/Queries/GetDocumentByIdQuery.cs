using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.DocumentFeatures.Queries
{
    public class GetDocumentByIdQuery : IRequest<Document>
    {
        public int Id { get; set; }
        public class GetDocumentByIdQueryHandler : IRequestHandler<GetDocumentByIdQuery, Document>
        {
            private readonly IApplicationContext _context;
            public GetDocumentByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<Document> Handle(GetDocumentByIdQuery query, CancellationToken cancellationToken)
            {
                var document = _context.Documents.Where(a => a.Id == query.Id).FirstOrDefault();
                if (document == null) return null;
                return document;
            }
        }

    }
}

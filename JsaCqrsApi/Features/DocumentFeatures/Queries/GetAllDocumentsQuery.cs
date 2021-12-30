using JsaCqrsApi.Infrastructure.Context;
using JsaCqrsApi.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.DocumentFeatures.Queries
{
    public class GetAllDocumentsQuery : IRequest<IEnumerable<Document>>
    {
        public class GetAllDocumentsQureyHandler : IRequestHandler<GetAllDocumentsQuery, IEnumerable<Document>>
        {
            private readonly IApplicationContext _context;
            public GetAllDocumentsQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Document>> Handle(GetAllDocumentsQuery request, CancellationToken cancellationToken)
            {
                var documentList = await _context.Documents.ToListAsync();
                if (documentList == null)
                {
                    return null;
                }
                return documentList.AsReadOnly();
            }
        }
    }
}

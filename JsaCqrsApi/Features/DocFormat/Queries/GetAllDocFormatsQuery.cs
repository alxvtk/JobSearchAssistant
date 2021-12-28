using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.DocFormatFeatures.Queries
{
    public class GetAllDocFormatsQuery : IRequest<IEnumerable<DocFormat>>
    {
        public class GetAllDocFormatsQureyHandler : IRequestHandler<GetAllDocFormatsQuery, IEnumerable<DocFormat>>
        {
            private readonly IApplicationContext _context;
            public GetAllDocFormatsQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<DocFormat>> Handle(GetAllDocFormatsQuery request, CancellationToken cancellationToken)
            {
                var docFormatList = await _context.DocFormats.ToListAsync();
                if (docFormatList == null)
                {
                    return null;
                }
                return docFormatList.AsReadOnly();
            }
        }
    }
}

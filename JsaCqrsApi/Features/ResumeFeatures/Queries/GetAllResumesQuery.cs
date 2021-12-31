using JsaCqrsApi.Infrastructure.Context;
using JsaCqrsApi.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.ResumeFeatures.Queries
{
    public class GetAllResumesQuery : IRequest<IEnumerable<Resume>>
    {
        public class GetAllResumesQureyHandler : IRequestHandler<GetAllResumesQuery, IEnumerable<Resume>>
        {
            private readonly IApplicationContext _context;
            public GetAllResumesQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Resume>> Handle(GetAllResumesQuery request, CancellationToken cancellationToken)
            {
                var resumeList = await _context.Resumes.ToListAsync();
                if (resumeList == null)
                {
                    return null;
                }
                return resumeList.AsReadOnly();
            }
        }
    }
}

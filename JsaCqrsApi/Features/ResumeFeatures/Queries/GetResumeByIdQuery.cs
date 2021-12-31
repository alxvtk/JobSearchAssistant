using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.ResumeFeatures.Queries
{
    public class GetResumeByIdQuery : IRequest<Resume>
    {
        public int Id { get; set; }
        public class GetResumeByIdQueryHandler : IRequestHandler<GetResumeByIdQuery, Resume>
        {
            private readonly IApplicationContext _context;
            public GetResumeByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<Resume> Handle(GetResumeByIdQuery query, CancellationToken cancellationToken)
            {
                var resume = _context.Resumes.Where(a => a.Id == query.Id).FirstOrDefault();
                if (resume == null) return null;
                return resume;
            }
        }

    }
}

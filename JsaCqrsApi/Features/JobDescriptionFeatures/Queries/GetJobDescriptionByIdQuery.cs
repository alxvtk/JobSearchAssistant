using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.JobDescriptionFeatures.Queries
{
    public class GetJobDescriptionByIdQuery : IRequest<JobDescription>
    {
        public int Id { get; set; }
        public class GetJobDescriptionByIdQueryHandler : IRequestHandler<GetJobDescriptionByIdQuery, JobDescription>
        {
            private readonly IApplicationContext _context;
            public GetJobDescriptionByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<JobDescription> Handle(GetJobDescriptionByIdQuery query, CancellationToken cancellationToken)
            {
                var jobDescription = _context.JobDescriptions.Where(a => a.Id == query.Id).FirstOrDefault();
                if (jobDescription == null) return null;
                return jobDescription;
            }
        }

    }
}

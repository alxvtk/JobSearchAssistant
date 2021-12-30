using JsaCqrsApi.Infrastructure.Context;
using JsaCqrsApi.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.JobDescriptionFeatures.Queries
{
    public class GetAllJobDescriptionsQuery : IRequest<IEnumerable<JobDescription>>
    {
        public class GetAllJobDescriptionsQureyHandler : IRequestHandler<GetAllJobDescriptionsQuery, IEnumerable<JobDescription>>
        {
            private readonly IApplicationContext _context;
            public GetAllJobDescriptionsQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<JobDescription>> Handle(GetAllJobDescriptionsQuery request, CancellationToken cancellationToken)
            {
                var jobDescriptionList = await _context.JobDescriptions.ToListAsync();
                if (jobDescriptionList == null)
                {
                    return null;
                }
                return jobDescriptionList.AsReadOnly();
            }
        }
    }
}

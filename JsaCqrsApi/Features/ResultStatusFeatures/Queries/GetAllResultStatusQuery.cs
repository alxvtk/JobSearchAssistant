using JsaCqrsApi.Infrastructure.Context;
using JsaCqrsApi.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace JsaCqrsApi.Application.Features.ResultStatus.Queries
{
    public class GetAllResultStatusQuery : IRequest<IEnumerable<JsaCqrsApi.Domain.Models.ResultStatus>>
    {
        public class GetAllResultStatusQueryHandler : IRequestHandler<GetAllResultStatusQuery, IEnumerable<JsaCqrsApi.Domain.Models.ResultStatus>>
        {
            private readonly IApplicationContext _context;
            public GetAllResultStatusQueryHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<JsaCqrsApi.Domain.Models.ResultStatus>> Handle(GetAllResultStatusQuery request, CancellationToken cancellationToken)
            {
                var resultStatusList = await _context.ResultStatuses.ToListAsync();
                if (resultStatusList == null)
                {
                    return null;
                }
                return resultStatusList.AsReadOnly();
            }
        }
    }
}

using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.ResultStatusFeatures.Queries
{
    public class GetResultStatusByIdQuery : IRequest<ResultStatus>
    {
        public int Id { get; set; }
        public class GetResultStatusByIdQueryHandler : IRequestHandler<GetResultStatusByIdQuery, ResultStatus>
        {
            private readonly IApplicationContext _context;
            public GetResultStatusByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<ResultStatus> Handle(GetResultStatusByIdQuery query, CancellationToken cancellationToken)
            {
                var resultStatus = _context.ResultStatuses.Where(a => a.Id == query.Id).FirstOrDefault();
                if (resultStatus == null) return null;
                return resultStatus;
            }
        }


    }
}

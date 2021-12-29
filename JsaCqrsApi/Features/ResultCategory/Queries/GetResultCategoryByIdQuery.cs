using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.ResultCategoryFeatures.Queries
{
    public class GetResultCategoryByIdQuery : IRequest<ResultCategory>
    {
        public int Id { get; set; }
        public class GetResultCategoryByIdQueryHandler : IRequestHandler<GetResultCategoryByIdQuery, ResultCategory>
        {
            private readonly IApplicationContext _context;
            public GetResultCategoryByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<ResultCategory> Handle(GetResultCategoryByIdQuery query, CancellationToken cancellationToken)
            {
                var resultCategory = _context.ResultCategorys.Where(a => a.Id == query.Id).FirstOrDefault();
                if (resultCategory == null) return null;
                return resultCategory;
            }
        }


    }
}

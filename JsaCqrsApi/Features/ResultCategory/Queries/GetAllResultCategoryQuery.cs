using JsaCqrsApi.Infrastructure.Context;
using JsaCqrsApi.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.ResultCategoryFeatures.Queries
{
    public class GetAllResultCategorysQuery : IRequest<IEnumerable<JsaCqrsApi.Domain.Models.ResultCategory>>
    {
        public class GetAllResultCategorysQueryHandler : IRequestHandler<GetAllResultCategorysQuery, IEnumerable<JsaCqrsApi.Domain.Models.ResultCategory>>
        {
            private readonly IApplicationContext _context;
            public GetAllResultCategorysQueryHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<JsaCqrsApi.Domain.Models.ResultCategory>> Handle(GetAllResultCategorysQuery request, CancellationToken cancellationToken)
            {
                var resultCategoryList = await _context.ResultCategorys.ToListAsync();
                if (resultCategoryList == null)
                {
                    return null;
                }
                return resultCategoryList.AsReadOnly();
            }
        }
    }
}

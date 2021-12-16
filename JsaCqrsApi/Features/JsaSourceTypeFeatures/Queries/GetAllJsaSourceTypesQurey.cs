using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.JsaSourceTypeFeatures.Queries
{
    public class GetAllJsaSourceTypesQurey : IRequest<IEnumerable<JsaSourceType>>
    {
        public class GetAllJsaSourceTypesQureyHandler : IRequestHandler<GetAllJsaSourceTypesQurey, IEnumerable<JsaSourceType>>
        {
            private readonly IApplicationContext _context;
            public GetAllJsaSourceTypesQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<JsaSourceType>> Handle(GetAllJsaSourceTypesQurey request, CancellationToken cancellationToken)
            {
                var jsaSourceTypeList = await _context.JsaSourceTypes.ToListAsync();
                if (jsaSourceTypeList == null)
                {
                    return null;
                }
                return jsaSourceTypeList.AsReadOnly();
            }
        }






        /*
                public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery,IEnumerable<Product>>
                {
                    private readonly IApplicationContext _context;
                    public GetAllProductsQueryHandler(IApplicationContext context)
                    {
                        _context = context;
                    }

                    public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery query, CancellationToken cancellationToken)
                    {
                        var productList = await _context.Products.ToListAsync();
                        if (productList == null)
                        {
                            return null;
                        }
                        return productList.AsReadOnly();
                    }
                }

        */
    }
}

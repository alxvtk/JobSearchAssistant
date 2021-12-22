using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.SourceTypeFeatures.Queries
{
    public class GetAllSourceTypesQurey : IRequest<IEnumerable<SourceType>>
    {
        public class GetAllSourceTypesQureyHandler : IRequestHandler<GetAllSourceTypesQurey, IEnumerable<SourceType>>
        {
            private readonly IApplicationContext _context;
            public GetAllSourceTypesQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<SourceType>> Handle(GetAllSourceTypesQurey request, CancellationToken cancellationToken)
            {
                var sourceTypeList = await _context.SourceTypes.ToListAsync();
                if (sourceTypeList == null)
                {
                    return null;
                }
                return sourceTypeList.AsReadOnly();
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

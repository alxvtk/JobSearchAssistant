using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.ResultCategoryFeatures.Commands
{
    public class DeleteResultCategoryByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }


        public class DeleteResultCategoryByIdCommandHandler : IRequestHandler<DeleteResultCategoryByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteResultCategoryByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteResultCategoryByIdCommand command, CancellationToken cancellationToken)
            {
                var resultCategory = _context.ResultCategorys.Where(a => a.Id == command.Id).FirstOrDefault();
                if (resultCategory == null) return default;
                _context.ResultCategorys.Remove(resultCategory);
                await _context.SaveChangesAsync();
                return resultCategory.Id;
            }
        }

    }
}

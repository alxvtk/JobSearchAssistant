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
    public class UpdateResultCategoryCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public class UpdateResultCategoryCommandHandler : IRequestHandler<UpdateResultCategoryCommand, int>
        {
            private readonly IApplicationContext _context;
            public UpdateResultCategoryCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateResultCategoryCommand command, CancellationToken cancellationToken)
            {
                var resultCategory = _context.ResultCategorys.Where(a => a.Id == command.Id).FirstOrDefault();
                if (resultCategory == null)
                {
                    return default;
                }
                else
                {
                    resultCategory.Name = command.Name;
                    resultCategory.Code = command.Code;
                    await _context.SaveChangesAsync();
                    return resultCategory.Id;
                }
            }

        }


    }
}

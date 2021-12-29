using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.ResultCategoryFeatures.Commands
{
    public class CreateResultCategoryCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public class CreateResultCategoryCommandHandler : IRequestHandler<CreateResultCategoryCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateResultCategoryCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateResultCategoryCommand command, CancellationToken cancellationToken)
            {
                var resultCategory = new ResultCategory();
                resultCategory.Id = command.Id;
                resultCategory.Name = command.Name;
                resultCategory.Code = command.Code;

                _context.ResultCategorys.Add(resultCategory);
                await _context.SaveChangesAsync();
                return resultCategory.Id;
            }
        }

    }
}

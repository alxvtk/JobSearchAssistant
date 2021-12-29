using JsaCqrsApi.Application.Features.ResultCategoryFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateResultCategoryCommandValidator : AbstractValidator<CreateResultCategoryCommand>
    {
        public CreateResultCategoryCommandValidator()
        {
            RuleFor(c => c.Code).NotNull().NotEmpty();
            RuleFor(c => c.Name).NotNull().NotEmpty();
        }
    }
}

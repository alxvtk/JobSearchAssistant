using JsaCqrsApi.Application.Features.ResultStatusFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateResultStatusCommandValidator : AbstractValidator<CreateResultStatusCommand>
    {
        public CreateResultStatusCommandValidator()
        {
            RuleFor(c => c.Name).NotNull().NotEmpty();
            RuleFor(c => c.Code).NotNull().NotEmpty();
            RuleFor(c => c.CategoryId).NotNull().GreaterThan(0);
        }

    }
}

using JsaCqrsApi.Application.Features.CountryFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateCountryCommandValidator : AbstractValidator<CreateCountryCommand>
    {
        public CreateCountryCommandValidator()
        {
            RuleFor(c => c.Code).NotNull().NotEmpty();
            RuleFor(c => c.Name).NotNull().NotEmpty();
        }
    }
}

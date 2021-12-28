using JsaCqrsApi.Application.Features.PhoneFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreatePhoneCommandValidator : AbstractValidator<CreatePhoneCommand>
    {
        public CreatePhoneCommandValidator()
        {
            RuleFor(c => c.Number).NotNull().NotEmpty();
            RuleFor(c => c.Name).NotNull().NotEmpty();
            RuleFor(c => c.Fax).NotNull().NotEmpty();
            RuleFor(c => c.Comment).NotNull().NotEmpty();
        }
    }
}

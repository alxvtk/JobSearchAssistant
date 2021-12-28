using JsaCqrsApi.Application.Features.EmailFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateEmailCommandValidator : AbstractValidator<CreateEmailCommand>
    {
        public CreateEmailCommandValidator()
        {
            RuleFor(c => c.Address).NotNull().NotEmpty();
            RuleFor(c => c.Comment).NotNull().NotEmpty();
        }
    }
}

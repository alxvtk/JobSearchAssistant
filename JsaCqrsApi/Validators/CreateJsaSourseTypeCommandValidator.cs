using JsaCqrsApi.Application.Features.JsaSourceTypeFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateJsaSourseTypeCommandValidator : AbstractValidator<CreateJsaSourceTypeCommand>
    {
        public CreateJsaSourseTypeCommandValidator()
        {
            RuleFor(c => c.StType).NotNull().NotEmpty();
            RuleFor(c => c.StTypeName).NotNull().NotEmpty();
        }
    }
}

using JsaCqrsApi.Application.Features.SourceTypeFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateSourseTypeCommandValidator : AbstractValidator<CreateSourceTypeCommand>
    {
        public CreateSourseTypeCommandValidator()
        {
            RuleFor(c => c.StType).NotNull().NotEmpty();
            RuleFor(c => c.StTypeName).NotNull().NotEmpty();
        }
    }
}

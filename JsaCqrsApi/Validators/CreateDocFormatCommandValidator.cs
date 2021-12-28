using JsaCqrsApi.Application.Features.DocFormatFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateDocFormatCommandValidator : AbstractValidator<CreateDocFormatCommand>
    {
        public CreateDocFormatCommandValidator()
        {
            RuleFor(c => c.Type).NotNull().NotEmpty();
        }

    }
}

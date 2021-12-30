using JsaCqrsApi.Application.Features.DocumentFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateDocumentCommandValidator : AbstractValidator<CreateDocumentCommand>
    {
        public CreateDocumentCommandValidator()
        {
            RuleFor(c => c.UrLinklId).NotNull().GreaterThan(0);
            RuleFor(c => c.EmailId).NotNull().GreaterThan(0);
            RuleFor(c => c.DocFormatId).NotNull().GreaterThan(0);
            RuleFor(c => c.Body).NotNull().NotEmpty();
            RuleFor(c => c.FullPath).NotNull().NotEmpty();
        }
    }
}

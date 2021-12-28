using JsaCqrsApi.Application.Features.UrlLinkFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateUrlLinkCommandValidator : AbstractValidator<CreateUrlLinkCommand>
    {
        public CreateUrlLinkCommandValidator()
        {
            RuleFor(c => c.Body).NotNull().NotEmpty();
            RuleFor(c => c.Comment).NotNull().NotEmpty();
        }
    }
}

using JsaCqrsApi.Application.Features.ResumeFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateResumeCommandValidator : AbstractValidator<CreateResumeCommand>
    {
        public CreateResumeCommandValidator()
        {
            RuleFor(c => c.DocumentId).NotNull().GreaterThanOrEqualTo(0);
            RuleFor(c => c.Version).NotNull().GreaterThanOrEqualTo(0);
            RuleFor(c => c.SubVersion).NotNull().GreaterThanOrEqualTo(0);
            RuleFor(c => c.VersioningDate).NotNull();
            RuleFor(c => c.Active).NotNull().NotEmpty();
        }
    }
}

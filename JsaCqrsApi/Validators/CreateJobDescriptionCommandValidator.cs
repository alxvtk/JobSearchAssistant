using JsaCqrsApi.Application.Features.JobDescriptionFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateJobDescriptionCommandValidator : AbstractValidator<CreateJobDescriptionCommand>
    {
        public CreateJobDescriptionCommandValidator()
        {
            RuleFor(c => c.SourceId).NotNull().GreaterThanOrEqualTo(0);
            RuleFor(c => c.DocumentId).NotNull().GreaterThanOrEqualTo(0);
        }
    }
}

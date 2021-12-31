using JsaCqrsApi.Application.Features.OpportunityFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateOpportunityCommandValidator : AbstractValidator<CreateOpportunityCommand>
    {
        public CreateOpportunityCommandValidator()
        {
            RuleFor(c => c.JobDescriptionId).NotNull().GreaterThanOrEqualTo(0);
            RuleFor(c => c.ResumeId).NotNull().GreaterThanOrEqualTo(0);
            RuleFor(c => c.Active).NotNull();
    }
}
}

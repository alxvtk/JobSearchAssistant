using JsaCqrsApi.Application.Features.OpportunityDocumentFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateOpportunityDocumentCommandValidator : AbstractValidator<CreateOpportunityDocumentCommand>
    {
        public CreateOpportunityDocumentCommandValidator()
        {
            RuleFor(c => c.OpportunityId).NotNull().GreaterThanOrEqualTo(0);
            RuleFor(c => c.Document).NotNull().GreaterThanOrEqualTo(0);
        }
    }
}

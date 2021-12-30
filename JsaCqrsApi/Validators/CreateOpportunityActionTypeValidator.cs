using JsaCqrsApi.Application.Features.OpportunityActionTypeFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateOpportunityActionTypeCommandValidator : AbstractValidator<CreateOpportunityActionTypeCommand>
    {
        public CreateOpportunityActionTypeCommandValidator()
        {
            RuleFor(c => c.SequenceNumber).NotNull().GreaterThanOrEqualTo(1);
            RuleFor(c => c.Title).NotNull().NotEmpty();
            RuleFor(c => c.Description).NotNull().NotEmpty();
            RuleFor(c => c.Note).NotNull().NotEmpty();
        }
    }
}


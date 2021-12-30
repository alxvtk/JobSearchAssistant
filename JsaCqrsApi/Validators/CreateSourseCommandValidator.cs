using JsaCqrsApi.Application.Features.SourceFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateSourseCommandValidator : AbstractValidator<CreateSourceCommand>
    {
        public CreateSourseCommandValidator()
        {
            RuleFor(c => c.SourceTypeId).NotNull().GreaterThan(0);
            RuleFor(c => c.PersonId).NotNull().GreaterThan(0);
            RuleFor(c => c.UrlId).NotNull().GreaterThan(0);
            RuleFor(c => c.EmailId).NotNull().GreaterThan(0);
            RuleFor(c => c.Name).NotNull().NotEmpty();
            RuleFor(c => c.Comment).NotNull().NotEmpty();
        }
    }
}

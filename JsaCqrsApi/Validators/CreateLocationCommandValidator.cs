using JsaCqrsApi.Application.Features.LocationFeatures.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Validators
{
    public class CreateLocationCommandValidator : AbstractValidator<CreateLocationCommand>
    {
        public CreateLocationCommandValidator()
        {
            RuleFor(c => c.StreetNumber).NotNull().NotEmpty();
            //RuleFor(c => c.StreetNumberSuffix).NotNull().NotEmpty();
            RuleFor(c => c.StreetName).NotNull().NotEmpty();
            //RuleFor(c => c.StreetType).NotNull().NotEmpty();
            //RuleFor(c => c.StreetDirection).NotNull().NotEmpty();
            //RuleFor(c => c.Unit).NotNull().NotEmpty();
            RuleFor(c => c.Municipality).NotNull().NotEmpty();
            RuleFor(c => c.Province).NotNull().NotEmpty();
            RuleFor(c => c.CountryId).NotNull().NotEmpty();
            RuleFor(c => c.PostalCode).NotNull().NotEmpty();
            //RuleFor(c => c.StreetLine1).NotNull().NotEmpty();
            //RuleFor(c => c.StreetLine2).NotNull().NotEmpty();
            //RuleFor(c => c.Comments).NotNull().NotEmpty();

        }
    }
}

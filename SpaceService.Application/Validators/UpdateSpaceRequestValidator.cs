using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using SpaceService.Application.DTOs.Requests;

namespace SpaceService.Application.Validators
{
    public class UpdateSpaceRequestValidator : AbstractValidator<UpdateSpaceRequest>
    {
        public UpdateSpaceRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(x => x.Type) 
                .IsInEnum();

            RuleFor(x => x.Description)
                .NotEmpty()
                .MaximumLength(500);
            
            RuleFor(x => x.Capacity) 
                .GreaterThan(0);

            RuleFor(x => x.Price)
                .GreaterThanOrEqualTo(0);
        }
    }
}
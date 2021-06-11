using Business.Constants;
using Business.Helpers;
using Entities.DTOs;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UpdateCustomerDtoValidator : AbstractValidator<UpdateCustomerDto>
    {
        public UpdateCustomerDtoValidator()
        {
            RuleFor(x => x.CustomerNumber).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.BirthDate).NotEmpty();
            RuleFor(x => x.Gender).NotEmpty();
            RuleFor(x => x.EducationState).NotEmpty();
            RuleFor(x => x.EmploymentType).NotEmpty();
            RuleFor(x => x.OccupationID).NotEmpty();
            RuleFor(x => x.HouseStatus).NotEmpty();
            RuleFor(x => x.CitizenNumber).Must(ValidCID).WithMessage(Messages.InvalidCID);
        }
        private bool ValidCID(string arg)
        {
            return ValidationExtensions.IsCidValid(arg);
        }
    }
}
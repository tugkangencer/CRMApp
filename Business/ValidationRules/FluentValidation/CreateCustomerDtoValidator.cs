using Business.Constants;
using Business.Helpers;
using Entities.DTOs;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CreateCustomerDtoValidator : AbstractValidator<CreateCustomerDto>
    {
        public CreateCustomerDtoValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.MobilePhone).Must(ValidPhone).WithMessage(Messages.InvalidPhone);
            RuleFor(x => x.HomePhone).Must(ValidPhone).WithMessage(Messages.InvalidPhone);
            RuleFor(x => x.OfficePhone).Must(ValidPhone).WithMessage(Messages.InvalidPhone);
            RuleFor(x => x.CitizenNumber).Must(ValidCID).WithMessage(Messages.InvalidCID);
        }
        private bool ValidPhone(string arg)
        {
            return ValidationExtensions.IsPhoneValid(arg);
        }

        private bool ValidCID(string arg)
        {
            return ValidationExtensions.IsCidValid(arg);
        }
    }
}
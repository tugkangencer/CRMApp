using Business.Constants;
using Business.Helpers;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerContactValidator : AbstractValidator<CustomerContact>
    {
        public CustomerContactValidator()
        {
            RuleFor(x => x.CustomerNumber).NotEmpty();
            RuleFor(x => x.MobilePhone).Must(ValidPhone).WithMessage(Messages.InvalidPhone);
            RuleFor(x => x.HomePhone).Must(ValidPhone).WithMessage(Messages.InvalidPhone);
            RuleFor(x => x.OfficePhone).Must(ValidPhone).WithMessage(Messages.InvalidPhone);
            RuleFor(x => x.EmailAddress)?.EmailAddress().WithMessage(Messages.InvalidMail);
        }

        private bool ValidPhone(string arg)
        {
            return ValidationExtensions.IsPhoneValid(arg);
        }
    }
}
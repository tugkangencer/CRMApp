using Business.Constants;
using Business.Helpers;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerReferenceValidator : AbstractValidator<CustomerReference>
    {
        public CustomerReferenceValidator()
        {
            RuleFor(x => x.CustomerNumber).NotEmpty();
            RuleFor(x => x.ReferenceType).NotEmpty();
            RuleFor(x => x.ReferencePhone).Must(ValidPhone).WithMessage(Messages.InvalidPhone);
        }

        private bool ValidPhone(string arg)
        {
            return ValidationExtensions.IsPhoneValid(arg);
        }
    }
}
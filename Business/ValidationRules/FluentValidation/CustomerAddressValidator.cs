using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerAddressValidator : AbstractValidator<CustomerAddress>
    {
        public CustomerAddressValidator()
        {
            RuleFor(x => x.CustomerNumber).NotEmpty();
            RuleFor(x => x.RecipientName).NotEmpty();
            RuleFor(x => x.AddressType).NotEmpty();
            RuleFor(x => x.CountryID).NotEmpty();
            RuleFor(x => x.BuildingNumber).NotEmpty();
        }
    }
}
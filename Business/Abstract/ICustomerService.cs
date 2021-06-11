using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Create(CreateCustomerDto createCustomerDto);
        IResult Update(UpdateCustomerDto updateCustomerDto);
        IResult UpdateAddress(CustomerAddress customerAddress);
        IResult UpdateContact(CustomerContact customerContact);
        IResult UpdateReference(CustomerReference customerReference);
        IDataResult<List<CustomerAddress>> GetAddress(string customerNumber);
        IDataResult<List<CustomerContact>> GetContact(string customerNumber);
        IDataResult<List<CustomerDetail>> GetDetail(string customerNumber);
        IDataResult<List<CustomerEducation>> GetEducation(string customerNumber);
        IDataResult<List<CustomerHouse>> GetHouse(string customerNumber);
        IDataResult<List<CustomerIdentity>> GetIdentity(string customerNumber);
        IDataResult<List<CustomerProfession>> GetProfession(string customerNumber);
        IDataResult<List<CustomerReference>> GetReference(string customerNumber);
    }
}
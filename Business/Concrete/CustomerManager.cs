using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerAddressRepository _customerAddressRepository;
        private readonly ICustomerContactRepository _customerContactRepository;
        private readonly ICustomerDetailRepository _customerDetailRepository;
        private readonly ICustomerEducationRepository _customerEducationRepository;
        private readonly ICustomerHouseRepository _customerHouseRepository;
        private readonly ICustomerIdentityRepository _customerIdentityRepository;
        private readonly ICustomerProfessionRepository _customerProfessionRepository;
        private readonly ICustomerReferenceRepository _customerReferenceRepository;
        private readonly IMapper _mapper;

        public CustomerManager(ICustomerAddressRepository customerAddressRepository,
                               ICustomerContactRepository customerContactRepository,
                               ICustomerDetailRepository customerDetailRepository,
                               ICustomerEducationRepository customerEducationRepository,
                               ICustomerHouseRepository customerHouseRepository,
                               ICustomerIdentityRepository customerIdentityRepository,
                               ICustomerProfessionRepository customerProfessionRepository,
                               ICustomerReferenceRepository customerReferenceRepository,
                               IMapper mapper)
        {
            _customerAddressRepository = customerAddressRepository;
            _customerContactRepository = customerContactRepository;
            _customerDetailRepository = customerDetailRepository;
            _customerEducationRepository = customerEducationRepository;
            _customerHouseRepository = customerHouseRepository;
            _customerIdentityRepository = customerIdentityRepository;
            _customerProfessionRepository = customerProfessionRepository;
            _customerReferenceRepository = customerReferenceRepository;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(CreateCustomerDtoValidator))]
        public IResult Create(CreateCustomerDto createCustomerDto)
        {
            IResult result = BusinessRules.Run(CheckIfPhoneNumberExists(createCustomerDto.MobilePhone, createCustomerDto.HomePhone, createCustomerDto.OfficePhone),
                                               CheckIfCitizenNumberExists(createCustomerDto.CitizenNumber));

            if (result != null)
            {
                return result;
            }

            do { createCustomerDto.CustomerNumber = DateTime.Now.ToString("ffffff"); }
            while (_customerIdentityRepository.GetAll(c => c.CustomerNumber == createCustomerDto.CustomerNumber).Any());

            _customerAddressRepository.Add(_mapper.Map<CustomerAddress>(createCustomerDto));
            _customerContactRepository.Add(_mapper.Map<CustomerContact>(createCustomerDto));
            _customerDetailRepository.Add(_mapper.Map<CustomerDetail>(createCustomerDto));
            _customerEducationRepository.Add(_mapper.Map<CustomerEducation>(createCustomerDto));
            _customerHouseRepository.Add(_mapper.Map<CustomerHouse>(createCustomerDto));
            _customerIdentityRepository.Add(_mapper.Map<CustomerIdentity>(createCustomerDto));
            _customerProfessionRepository.Add(_mapper.Map<CustomerProfession>(createCustomerDto));
            _customerReferenceRepository.Add(_mapper.Map<CustomerReference>(createCustomerDto));

            return new SuccessResult(createCustomerDto.CustomerNumber);
        }

        [ValidationAspect(typeof(UpdateCustomerDtoValidator))]
        public IResult Update(UpdateCustomerDto updateCustomerDto)
        {
            _customerDetailRepository.Update(_mapper.Map<CustomerDetail>(updateCustomerDto));
            _customerEducationRepository.Update(_mapper.Map<CustomerEducation>(updateCustomerDto));
            _customerHouseRepository.Update(_mapper.Map<CustomerHouse>(updateCustomerDto));
            _customerIdentityRepository.Update(_mapper.Map<CustomerIdentity>(updateCustomerDto));
            _customerProfessionRepository.Update(_mapper.Map<CustomerProfession>(updateCustomerDto));

            return new SuccessResult(Messages.Success);
        }

        [ValidationAspect(typeof(CustomerAddressValidator))]
        public IResult UpdateAddress(CustomerAddress customerAddress)
        {
            if(customerAddress.AddressID == 0)
            {
                _customerAddressRepository.Add(customerAddress);
            } else {
                _customerAddressRepository.Update(customerAddress);
            }
            
            return new SuccessResult(Messages.Success);
        }

        [ValidationAspect(typeof(CustomerContactValidator))]
        public IResult UpdateContact(CustomerContact customerContact)
        {
            _customerContactRepository.Update(customerContact);

            return new SuccessResult(Messages.Success);
        }

        [ValidationAspect(typeof(CustomerReferenceValidator))]
        public IResult UpdateReference(CustomerReference customerReference)
        {
            if (customerReference.ReferenceID == 0)
            {
                _customerReferenceRepository.Add(customerReference);
            }
            else
            {
                _customerReferenceRepository.Update(customerReference);
            }

            return new SuccessResult(Messages.Success);
        }

        public IDataResult<List<CustomerAddress>> GetAddress(string customerNumber)
        {
            return new SuccessDataResult<List<CustomerAddress>>(_customerAddressRepository.GetAll(c => c.CustomerNumber == customerNumber), Messages.Success);
        }

        public IDataResult<List<CustomerContact>> GetContact(string customerNumber)
        {
            return new SuccessDataResult<List<CustomerContact>>(_customerContactRepository.GetAll(c => c.CustomerNumber == customerNumber), Messages.Success);
        }

        public IDataResult<List<CustomerDetail>> GetDetail(string customerNumber)
        {
            return new SuccessDataResult<List<CustomerDetail>>(_customerDetailRepository.GetAll(c => c.CustomerNumber == customerNumber), Messages.Success);
        }

        public IDataResult<List<CustomerEducation>> GetEducation(string customerNumber)
        {
            return new SuccessDataResult<List<CustomerEducation>>(_customerEducationRepository.GetAll(c => c.CustomerNumber == customerNumber), Messages.Success);
        }        

        public IDataResult<List<CustomerHouse>> GetHouse(string customerNumber)
        {
            return new SuccessDataResult<List<CustomerHouse>>(_customerHouseRepository.GetAll(c => c.CustomerNumber == customerNumber), Messages.Success);
        }

        public IDataResult<List<CustomerIdentity>> GetIdentity(string customerNumber)
        {
            if (customerNumber == "000000")
            {
                return new SuccessDataResult<List<CustomerIdentity>>(_customerIdentityRepository.GetAll(), Messages.Success);
            }
            return new SuccessDataResult<List<CustomerIdentity>>(_customerIdentityRepository.GetAll(c => c.CustomerNumber == customerNumber), Messages.Success);
        }

        public IDataResult<List<CustomerProfession>> GetProfession(string customerNumber)
        {
            return new SuccessDataResult<List<CustomerProfession>>(_customerProfessionRepository.GetAll(c => c.CustomerNumber == customerNumber), Messages.Success);
        }

        public IDataResult<List<CustomerReference>> GetReference(string customerNumber)
        {
            return new SuccessDataResult<List<CustomerReference>>(_customerReferenceRepository.GetAll(c => c.CustomerNumber == customerNumber), Messages.Success);
        }

        private IResult CheckIfPhoneNumberExists(string mobilePhone, string homePhone, string officePhone)
        {
            bool mp = string.IsNullOrWhiteSpace(mobilePhone);
            bool hp = string.IsNullOrWhiteSpace(homePhone);
            bool op = string.IsNullOrWhiteSpace(officePhone);

            if (mp && hp && op)
            {
                return new ErrorResult(Messages.RequiredFields);
            }
            
            if (_customerContactRepository.GetAll(c => c.MobilePhone == mobilePhone).Any() && !mp)
            {
                return new ErrorResult(Messages.PhoneAlreadyExists);
            }

            if (_customerContactRepository.GetAll(c => c.HomePhone == homePhone).Any() && !hp)
            {
                return new ErrorResult(Messages.PhoneAlreadyExists);
            }

            if (_customerContactRepository.GetAll(c => c.OfficePhone == officePhone).Any() && !op)
            {
                return new ErrorResult(Messages.PhoneAlreadyExists);
            }

            return new SuccessResult();
        }

        private IResult CheckIfCitizenNumberExists(string citizenNumber)
        {
            if (string.IsNullOrWhiteSpace(citizenNumber))
                return new SuccessResult();

            if (_customerIdentityRepository.GetAll(c => c.CitizenNumber == citizenNumber).Any())
            {
                return new ErrorResult(Messages.CitizenNumberAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
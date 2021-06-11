using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Helpers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CreateCustomerDto, CustomerAddress>().ReverseMap();
            CreateMap<CreateCustomerDto, CustomerContact>().ReverseMap();
            CreateMap<CreateCustomerDto, CustomerDetail>().ReverseMap();
            CreateMap<CreateCustomerDto, CustomerEducation>().ReverseMap();
            CreateMap<CreateCustomerDto, CustomerHouse>().ReverseMap();
            CreateMap<CreateCustomerDto, CustomerIdentity>().ReverseMap();
            CreateMap<CreateCustomerDto, CustomerProfession>().ReverseMap();
            CreateMap<CreateCustomerDto, CustomerReference>().ReverseMap();

            CreateMap<UpdateCustomerDto, CustomerDetail>().ReverseMap();
            CreateMap<UpdateCustomerDto, CustomerEducation>().ReverseMap();
            CreateMap<UpdateCustomerDto, CustomerHouse>().ReverseMap();
            CreateMap<UpdateCustomerDto, CustomerIdentity>().ReverseMap();
            CreateMap<UpdateCustomerDto, CustomerProfession>().ReverseMap();
        }
    }
}
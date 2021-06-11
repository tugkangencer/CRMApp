using Core.Entities;
using System;

namespace Entities.DTOs
{
    public class CreateCustomerDto : IDto
    {
        public string CustomerNumber { get; set; }
        public string Branch { get; set; }
        public int? NationalityID { get; set; }
        public int? SettlementCountryID { get; set; }
        public string CitizenNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public int? BirthPlaceID { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public DateTime? FirstContactDate { get; set; }
        public string PersonalDataStatus { get; set; }
        public string CommunicationLanguage { get; set; }
        public string RecipientName { get; set; }
        public string AddressType { get; set; }
        public int? CountryID { get; set; }
        public int? CityID { get; set; }
        public int? DistrictID { get; set; }
        public int? NeighborhoodID { get; set; }
        public string MainStreet { get; set; }
        public string Street { get; set; }
        public string BuildingName { get; set; }
        public int? BuildingNumber { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string OfficePhone { get; set; }
        public string EmailAddress { get; set; }
        public string WebAddress { get; set; }
        public int? OccupationID { get; set; }
        public string EmploymentType { get; set; }
        public string IncomeClass { get; set; }
    }
}
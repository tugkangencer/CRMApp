using Core.Entities;
using System;

namespace Entities.DTOs
{
    public class UpdateCustomerDto : IDto
    {
        public string CustomerNumber { get; set; }
        public int? NationalityID { get; set; }
        public int? SettlementCountryID { get; set; }
        public string NativeLanguage { get; set; }
        public string CommunicationLanguage { get; set; }
        public string CustomerType { get; set; }
        public string PersonalDataStatus { get; set; }
        public string CustomerStatus { get; set; }
        public string Segment { get; set; }
        public string Branch { get; set; }
        public string RiskClass { get; set; }
        public string CapacityToAct { get; set; }
        public string DisabilityType { get; set; }
        public string MaidenName { get; set; }
        public string MotherMaidenName { get; set; }
        public DateTime? FirstContactDate { get; set; }
        public int? BirthPlaceID { get; set; }
        public DateTime? BirthDate { get; set; }
        public string CitizenNumber { get; set; }
        public string SerialNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Gender { get; set; }
        public string Language_EN { get; set; }
        public string Language_AR { get; set; }
        public string Language_DE { get; set; }
        public string Language_FR { get; set; }
        public string Language_IT { get; set; }
        public string Language_PT { get; set; }
        public string Language_FA { get; set; }
        public string Language_ES { get; set; }
        public string Language_RU { get; set; }
        public string Language_TR { get; set; }
        public string Language_JA { get; set; }
        public string Language_ZH { get; set; }
        public string EducationState { get; set; }
        public string MilitaryService { get; set; }
        public string LastCompletedSchool { get; set; }
        public DateTime? GraduationDate { get; set; }
        public int? OccupationID { get; set; }
        public int? SectorID { get; set; }
        public string EmploymentType { get; set; }
        public string IncomeClass { get; set; }
        public string BusinessName { get; set; }
        public string SocialSecurityInstitution { get; set; }
        public string SocialSecurityNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public string HouseStatus { get; set; }
        public int? PersonNumber { get; set; }
        public int? ChildNumber { get; set; }
        public int? ResidenceYear { get; set; }
        public int? detailID { get; set; }
        public int? educationID { get; set; }
        public int? houseID { get; set; }
        public int? identityID { get; set; }
        public int? professionID { get; set; }
    }
}
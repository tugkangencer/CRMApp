using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class CustomerDetail : IEntity
    {
        [Key]
        public int DetailID { get; set; }
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
        public System.DateTime? FirstContactDate { get; set; }
    }
}
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class CustomerProfession : IEntity
    {
        [Key]
        public int ProfessionID { get; set; }
        public string CustomerNumber { get; set; }
        public int? OccupationID { get; set; }
        public int? SectorID { get; set; }
        public string EmploymentType { get; set; }
        public string IncomeClass { get; set; }
        public string BusinessName { get; set; }
        public string SocialSecurityInstitution { get; set; }
        public string SocialSecurityNumber { get; set; }
        public System.DateTime? StartDate { get; set; }
    }
}
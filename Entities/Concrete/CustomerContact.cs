using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class CustomerContact : IEntity
    {
        [Key]
        public int ContactID { get; set; }
        public string CustomerNumber { get; set; }
        public string MobilePhone { get; set; }
        public string MobilePhoneStatus { get; set; }
        public string HomePhone { get; set; }
        public string HomePhoneStatus { get; set; }
        public string OfficePhone { get; set; }
        public string OfficePhoneStatus { get; set; }
        public string EmailAddress { get; set; }
        public string EmailStatus { get; set; }
        public string WebAddress { get; set; }
    }
}
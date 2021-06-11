using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class CustomerIdentity : IEntity
    {
        [Key]
        public int IdentityID { get; set; }
        public string CustomerNumber { get; set; }
        public int? BirthPlaceID { get; set; }
        public System.DateTime? BirthDate { get; set; }
        public string CitizenNumber { get; set; }
        public string SerialNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Gender { get; set; }
    }
}
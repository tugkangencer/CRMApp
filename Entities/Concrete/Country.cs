using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Country : IEntity
    {
        [Key]
        public int CountryID { get; set; }
        public string BinaryCode { get; set; }
        public string TripleCode { get; set; }
        public string CountryName { get; set; }
        public string PhoneCode { get; set; }
    }
}
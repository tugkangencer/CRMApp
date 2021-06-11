using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class City : IEntity
    {
        [Key]
        public int CityID { get; set; }
        public int CountryID { get; set; }
        public string CityName { get; set; }
        public string PlateNo { get; set; }
        public string PhoneCode { get; set; }
    }
}
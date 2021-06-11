using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class CustomerHouse : IEntity
    {
        [Key]
        public int HouseID { get; set; }
        public string CustomerNumber { get; set; }
        public string HouseStatus { get; set; }
        public int? PersonNumber { get; set; }
        public int? ChildNumber { get; set; }
        public int? ResidenceYear { get; set; }
    }
}
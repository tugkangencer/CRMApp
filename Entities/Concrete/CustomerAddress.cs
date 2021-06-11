using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class CustomerAddress : IEntity
    {
        [Key]
        public int AddressID { get; set; }
        public string CustomerNumber { get; set; }
        public int? CountryID { get; set; }
        public int? CityID { get; set; }
        public int? DistrictID { get; set; }
        public int? NeighborhoodID { get; set; }
        public string AddressType { get; set; }
        public string AddressStatus { get; set; }
        public string RecipientName { get; set; }
        public string MainStreet { get; set; }
        public string Street { get; set; }
        public string BuildingName { get; set; }
        public int? BuildingNumber { get; set; }
    }
}
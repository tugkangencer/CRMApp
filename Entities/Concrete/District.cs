using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class District : IEntity
    {
        [Key]
        public int DistrictID { get; set; }
        public int CityID { get; set; }
        public string DistrictName { get; set; }
    }
}
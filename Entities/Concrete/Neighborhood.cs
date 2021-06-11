using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Neighborhood : IEntity
    {
        [Key]
        public int NeighborhoodID { get; set; }
        public int DistrictID { get; set; }
        public string NeighborhoodName { get; set; }
        public string ZipCode { get; set; }
    }
}
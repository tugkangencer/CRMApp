using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Sector : IEntity
    {
        [Key]
        public int SectorID { get; set; }
        public string SectorName { get; set; }
    }
}
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Occupation : IEntity
    {
        [Key]
        public int OccupationID { get; set; }
        public string OccupationName { get; set; }
    }
}
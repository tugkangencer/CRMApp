using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class CustomerReference : IEntity
    {
        [Key]
        public int ReferenceID { get; set; }
        public string CustomerNumber { get; set; }
        public string ReferenceType { get; set; }
        public string ReferenceName { get; set; }
        public string ReferencePhone { get; set; }
    }
}
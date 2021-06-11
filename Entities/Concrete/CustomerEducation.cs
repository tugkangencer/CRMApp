using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class CustomerEducation : IEntity
    {
        [Key]
        public int EducationID { get; set; }
        public string CustomerNumber { get; set; }
        public string EducationState { get; set; }
        public string MilitaryService { get; set; }
        public string LastCompletedSchool { get; set; }
        public string Language_EN { get; set; }
        public string Language_AR { get; set; }
        public string Language_DE { get; set; }
        public string Language_FR { get; set; }
        public string Language_IT { get; set; }
        public string Language_PT { get; set; }
        public string Language_FA { get; set; }
        public string Language_ES { get; set; }
        public string Language_RU { get; set; }
        public string Language_TR { get; set; }
        public string Language_JA { get; set; }
        public string Language_ZH { get; set; }
        public System.DateTime? GraduationDate { get; set; }
    }
}
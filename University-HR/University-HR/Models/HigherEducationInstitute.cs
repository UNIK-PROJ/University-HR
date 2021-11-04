using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_HR.Models
{
    class HigherEducationInstitute
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string InstituteName { get; set; }

        [Required]
        public DateTime YearOfCompletion { get; set; }
        [Required]
        public string Specialization { get; set; }

        [Required]
        public string Qualification { get; set; }

        [Required]
        public double SpecializationNumber { get; set; }

        public List<TeacherInfo> TeacherInfos { get; set; }
    }
}

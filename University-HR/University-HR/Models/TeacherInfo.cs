using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_HR.Models
{
    class TeacherInfo
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime Birth { get; set; }

        [Required]
        public string RegistrationAdress { get; set; }

        [Required]
        public string HomeAdress { get; set; }

        [Required]
        public int Phone { get; set; }

        [Required]
        public string Rank { get; set; }

        [Required]
        public string Degree { get; set; }

        [Required]
        public DateTime DateOfEmployment { get; set; }

        [Required]
        public int WorkExpirience { get; set; }

        [Required]
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }

    }
}

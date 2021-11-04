using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace University_HR.Models
{
    class AdditionalPhone
    {

        [Required]
        public int Id { get; set; }

        [Required]
        public int Phone { get; set; }

        public List<TeacherInfo> TeacherInfos { get; set; }

    }
}

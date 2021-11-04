using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_HR.Models
{
    class Cathedra
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string CathedraName { get; set; }

        
    }
}

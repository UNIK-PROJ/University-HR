using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_HR.Models
{
    class Occupation
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string OccupationName { get; set; }

        [Required]
        public int CathedraId { get; set; }

        public List<Cathedra> Cathedras { get; set; }
    }
}

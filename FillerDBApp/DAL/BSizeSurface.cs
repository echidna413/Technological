using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BSizeSurface
    {
        [ForeignKey("surface_id")]
        public BSurface BSurface { get; set; }

        [Key]
        public int size_id { get; set; }
        public int surface_id { get; set; }
        public int size_description_id { get; set; }
        public double nominal { get; set; }
        public string finish { get; set; }
        public double max_deviation { get; set; }
        public double min_deviation { get; set; }
        public double tolerance { get; set; }
        public bool symmetry { get; set; }
    }
}

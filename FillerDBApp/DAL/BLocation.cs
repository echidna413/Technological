using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BLocation
    {
        [ForeignKey("surface_id")]
        public BSurface BSurface { get; set; }

        [Key]
        public int location_id { get; set; }
        public int surface_id { get; set; }
        public int relation_surface_id { get; set; }
        public int code_location_id { get; set; }
        public double limit_deviation { get; set; }
    }
}

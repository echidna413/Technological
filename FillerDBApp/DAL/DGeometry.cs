using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DGeometry
    {
        [ForeignKey("surface_id")]
        public DSurface DSurface { get; set; }

        [Key]
        public int deviation_id { get; set; }
        public int surface_id { get; set; }
        public int code_deviation_id { get; set; }
        public double class_deviation { get; set; }
        public double value_deviation { get; set; }
    }
}

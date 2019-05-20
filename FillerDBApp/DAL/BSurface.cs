using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BSurface
    {
        [ForeignKey("billet_id")]
        public BDescription BDescription { get; set; }

        [Key]
        public int surface_id { get; set; }
        public int billet_id { get; set; }
        public double number_surface { get; set; }
        public int code_surface_id { get; set; }
        public double zero_point_X { get; set; }
        public double zero_point_Y { get; set; }
        public double zero_point_Z { get; set; }
        public double ra { get; set; }
        public double rnax { get; set; }
        public double s { get; set; }
    }
}

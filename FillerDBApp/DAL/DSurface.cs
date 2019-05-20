using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DSurface
    {
        public DSurface()
        {

        }

        [ForeignKey("detail_id")]
        public DDescription DDescription { get; set; }

        [Key]
        public int surface_id { get; set; }
        public int detail_id { get; set; }
        public double number_surface { get; set; }
        public string code_surface { get; set; }
        public double zero_point_X { get; set; }
        public double zero_point_Y { get; set; }
        public double zero_point_Z { get; set; }
        public double ra { get; set; }
        public double rmax { get; set; }
        public double s { get; set; }
        public double tp { get; set; }
        public double hrc { get; set; }
        public double depth { get; set; }
        public double internal_stress_1 { get; set; }
        public double internal_stress_2 { get; set; }
        public double internal_stress_3 { get; set; }
        public bool constructor_base { get; set; }
        public double orientation { get; set; }
        public bool requirement { get; set; }
        public string image { get; set; }
    }
}

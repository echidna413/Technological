using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EBaseLocation
    {
        [ForeignKey("base_requirement_id")]
        public EBaseSurface EBaseSurface { get; set; }

        [Key, Column(Order =0)]
        public int base_requirement_id { get; set; }
        [Key, Column(Order = 1)]
        public double location_number { get; set; } //??????????????
        public double size_x_min { get; set; }
        public double size_x_max { get; set; }
        public double size_y_min { get; set; }
        public double size_y_max { get; set; }
        public double size_z_min { get; set; }
        public double size_z_max { get; set; }
    } 
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Base
    {
        [Key]
        public int device_id { get; set; }
        public int number_base_surface { get; set; }
        public double code_surface { get; set; }
        public double orientation { get; set; }
        public double com_1_max { get; set; }
        public double com_1_min { get; set; }
        public double com_2_max { get; set; }
        public double com_2_min { get; set; }
        public double com_3_max { get; set; }
        public double com_3_min { get; set; }
    }
}

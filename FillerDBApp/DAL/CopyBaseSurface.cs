using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CopyBaseSurface
    {
        [Key]
        public int id { get; set; }
        public double number_equipment { get; set; }
        public double number_base_surface { get; set; }
        public double code_surface { get; set; }
        public double com_1_max { get; set; }
        public double com_1_min { get; set; }
        public double com_1_tol { get; set; }
        public double com_2_max { get; set; }
        public double com_2_min { get; set; }
        public double com_2_tol { get; set; }
        public double com_3_max { get; set; }
        public double com_3_min { get; set; }
        public double com_3_tol { get; set; }
        public double com_4_max { get; set; }
        public double com_4_min { get; set; }
        public double com_4_tol { get; set; }
        public double com_5_max { get; set; }
        public double com_5_min { get; set; }
        public double com_5_tol { get; set; }
        public double com_6_max { get; set; }
        public double com_6_min { get; set; }
        public double com_6_tol { get; set; }
        public double com_7_max { get; set; }
        public double com_7_min { get; set; }
        public double com_7_tol { get; set; }
        public double com_8_max { get; set; }
        public double com_8_min { get; set; }
        public double com_8_tol { get; set; }
        public double locprocess_base_max { get; set; }
        public double locprocess_base_min { get; set; }
        public double loc_first_base_max { get; set; }
        public double loc_first_base_min { get; set; }
        public double loc_second_base_max { get; set; }
        public double loc_second_base_min { get; set; }
    }
}

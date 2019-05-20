using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EBaseTmp
    {
        [Key]
        public int id { get; set; }
        public int record_id { get; set; }
        public double number_base_surface { get; set; }
        public double code_surface { get; set; }
        public double com_1_max { get; set; }
        public double com_1_min { get; set; }
        public string com_1_tol { get; set; }
        public double com_2_max { get; set; }
        public double com_2_min { get; set; }
        public string com_2_tol { get; set; }
        public double com_3_max { get; set; }
        public double com_3_min { get; set; }
        public string com_3_tol { get; set; }
        public double com_4_max { get; set; }
        public double com_4_min { get; set; }
        public string com_4_tol { get; set; }
        public double loc_processbase_min { get; set; }
        public double loc_processbase_max { get; set; }
        public double loc_firstbase_min { get; set; }
        public double loc_firstbase_max { get; set; }
        public double loc_secondbase_min { get; set; }
        public double loc_secondbase_max { get; set; }
    }
}

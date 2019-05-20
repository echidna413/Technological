using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ECarriage
    {
        [ForeignKey("lathe_id")]
        public ELathe ELathe { get; set; }

        [Key]
        public int carriage_id { get; set; }
        public int lathe_id { get; set; }
        public string name { get; set; }
        public double position_count { get; set; }
        public bool synchronization { get; set; }
        public bool parallel_processing { get; set; }
        public double move_x_value { get; set; }
        public double move_y_value { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ESpindle
    {
        [ForeignKey("lathe_id")]
        public ELathe ELathe { get; set; }

        [Key]
        public int spindle_id { get; set; }
        public int lathe_id { get; set; }
        public string name { get; set; }
        public bool step_feed { get; set; }
        public double min_value { get; set; }
        public double max_value { get; set; }
        public bool reverse_feed { get; set; }
    }
}

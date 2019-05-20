using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ESpeed
    {
        [ForeignKey("spindle_id")]
        public ESpindle ESpindle { get; set; }

        [Key]
        public int speed_id { get; set; }
        public int spindle_id { get; set; }
        public bool reverse { get; set; }
        public double value { get; set; }
    }
}

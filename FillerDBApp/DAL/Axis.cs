using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Axis
    {
        [Key]
        public int axis_id { get; set; }
        public string name { get; set; }

    }
}

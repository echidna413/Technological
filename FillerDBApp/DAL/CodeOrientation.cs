using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CodeOrientation
    {
        [Key]
        public int orientation_id { get; set; }
        public double code_orientation { get; set; }
        public string description { get; set; }
    }
}

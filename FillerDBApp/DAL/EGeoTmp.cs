using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EGeoTmp
    {
        [Key]
        public int id { get; set; }
        public int deviation_id { get; set; }
        public double code_deviation { get; set; }
        public double value_deviation { get; set; }
        public double class_deviation { get; set; }
    }
}

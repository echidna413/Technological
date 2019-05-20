using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CodeDeviationLocation
    {
        [Key]
        public int code_geo_deviation_id { get; set; }
        public string description { get; set; }
        public string image_big { get; set; }
        public string image_small { get; set; }
    }
}

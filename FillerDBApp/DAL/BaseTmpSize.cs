using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseTmpSize
    {
        [Key]
        public int id { get; set; }
        public double base_number { get; set; }
        public double code_surface { get; set; }
        public double orientation { get; set; }
        public double size_number { get; set; }
        public double size_description_id { get; set; }
        public string description { get; set; }
        public double max_value { get; set; }
        public double min_value { get; set; }
    }
}

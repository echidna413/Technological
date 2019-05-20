using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseTmpLocation
    {
        [Key]
        public int id { get; set; }
        public double base_number { get; set; }
        public double location_number { get; set; }
        public double size_X_min { get; set; }
        public double size_X_max { get; set; }
        public double size_Y_min { get; set; }
        public double size_Y_max { get; set; }
        public double size_Z_min { get; set; }
        public double size_Z_max { get; set; }
        public string description { get; set; }
    }
}

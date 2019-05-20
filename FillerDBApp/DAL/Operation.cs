using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Operation
    {
        [Key]
        public int id { get; set; }
        public double number_operation { get; set; }
        public double number_group { get; set; }
        public string name_operation { get; set; }
    }
}

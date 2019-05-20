using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GroupOperation
    {
        [Key]
        public int id { get; set; }
        public double number_group { get; set; }
        public string name_group { get; set; }
        public string description { get; set; }
    }
}

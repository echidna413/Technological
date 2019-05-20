using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SizeDescription
    {
        [Key]
        public int size_description_id { get; set; }
        public double size_number { get; set; }
        public string description { get; set; }
    }
}

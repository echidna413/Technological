using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Tree
    {
        [Key]
        public int id { get; set; }
        public string variant_tp { get; set; }
        public double detail { get; set; }
        public double surface { get; set; }
    }
}

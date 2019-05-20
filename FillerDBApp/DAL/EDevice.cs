using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EDevice
    {
        [ForeignKey("base_scheme_id")]
        public EBaseScheme EBaseScheme { get; set; }

        [Key]
        public int device_id { get; set; }
        public int base_scheme_id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public bool enabled { get; set; }
        public string description { get; set; }
    }
}

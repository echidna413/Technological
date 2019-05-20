using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EBaseSurface
    {
        [ForeignKey("base_scheme_id")]
        public EBaseScheme EBaseScheme { get; set; }

        [Key]
        public int base_requirement_id { get; set; }
        public int base_scheme_id { get; set; }
        public double base_number { get; set; }
        public string code_surface { get; set; }
        public double orientation { get; set; }
    }
}

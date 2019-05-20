using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CodeTypeBillet
    {
        [Key]
        public int id { get; set; }
        public int code_type_billet_id { get; set; }
        public string name { get; set; }
    }
}

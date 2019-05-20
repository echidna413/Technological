using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TypeProcess
    {
        [Key]
        public int type_process_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}

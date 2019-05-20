using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EGroup
    {
        [Key]
        public int group_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}

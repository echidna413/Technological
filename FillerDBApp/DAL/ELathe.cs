using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ELathe
    {
        [ForeignKey("group_id")]
        public EGroup EGroup { get; set; }

        [Key]
        public int lathe_id { get; set; }
        public int group_id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public bool enabled { get; set; }
        public string description { get; set; }
    }
}

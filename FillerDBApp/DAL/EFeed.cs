using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EFeed
    {
        [ForeignKey("carriage_id")]
        public ECarriage ECarriage { get; set; }

        [Key]
        public int feed_id { get; set; }
        public int carriage_id { get; set; }
        public int axis { get; set; }
        public double value { get; set; }
    }
}

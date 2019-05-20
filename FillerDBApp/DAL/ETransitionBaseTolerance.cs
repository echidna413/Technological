using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ETransitionBaseTolerance
    {
        [ForeignKey("base_requirement_id")]
        public ETransitionBase ETransitionBase { get; set; }

        [Key, Column(Order = 0)]
        public int base_requirement_id { get; set; }
        [Key, Column(Order = 1)]
        public double size_number { get; set; }
        public double tolerance { get; set; }
        public int size_description_id { get; set; }
    }
}

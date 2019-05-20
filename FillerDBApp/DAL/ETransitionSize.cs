using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ETransitionSize
    {
        [ForeignKey("transition_id")]
        public ETransition ETransition { get; set; }

        [Key, Column(Order = 0)]
        public int transition_id { get; set; }
        [Key, Column(Order = 1)]
        public double size_number { get; set; }
        public double min_value { get; set; }
        public double max_value { get; set; }
        public int size_description_id { get; set; }
    }
}

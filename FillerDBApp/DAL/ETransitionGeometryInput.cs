using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ETransitionGeometryInput
    {
        [ForeignKey("transition_id")]
        public ETransition ETransition { get; set; }

        [Key, Column(Order = 0)]
        public int transition_id { get; set; }
        [Key, Column(Order = 1)]
        public int code_deviation_id { get; set; }
        public double value { get; set; }
        public double class_ { get; set; }
    }
}

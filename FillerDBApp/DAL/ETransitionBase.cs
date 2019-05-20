using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ETransitionBase
    {
        [ForeignKey("transition_id")]
        public ETransition ETransition { get; set; }

        [Key]
        public int base_requirement_id { get; set; }
        public int transition_id { get; set; }
        public double base_number { get; set; }
        public string code_surface { get; set; }
    }
}

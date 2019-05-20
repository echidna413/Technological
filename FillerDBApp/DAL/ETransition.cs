using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ETransition
    {
        [ForeignKey("base_scheme_id")]
        public EBaseScheme EBaseScheme { get; set; }

        [Key]
        public int transition_id { get; set; }
        public int base_scheme_id { get; set; }
        public int type_process_id { get; set; }
        public string code_output_surface { get; set; }
        public double output_tolerance { get; set; }
        public double output_ra { get; set; }
        public double output_rmax { get; set; }
        public double output_tp { get; set; }
        public double output_s { get; set; }
        public double output_hrc { get; set; }
        public double output_depth { get; set; }
        public double output_internalstress_1 { get; set; }
        public double output_internalstress_2 { get; set; }
        public double output_internalstress_3 { get; set; }
        public string code_input_surface { get; set; }
        public double input_tolerance { get; set; }
        public double input_ra { get; set; }
        public double input_rmax { get; set; }
        public double input_tp { get; set; }
        public double input_s { get; set; }
        public double input_hrc { get; set; }
        public double input_depth { get; set; }
        public double input_internalstress_1 { get; set; }
        public double input_internalstress_2 { get; set; }
        public double input_internalstress_3 { get; set; }
        public string mark_material { get; set; }
        public bool enabled { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EDescription
    {
        [ForeignKey("id_employee")]
        public Employee Employee { get; set; }

        [ForeignKey("id_company")]
        public Company Company { get; set; }

        [Key]
        public int number_equipment { get; set; }
        public int id_employee { get; set; }
        public int id_company { get; set; }
        public int device_id { get; set; }
        public double view_process { get; set; }
        public double code_surface_output { get; set; }
        public double sizesurface_1_max { get; set; }
        public double sizesurface_1_min { get; set; }
        public double sizesurface_2_max { get; set; }
        public double sizesurface_2_min { get; set; }
        public double sizesurface_3_max { get; set; }
        public double sizesurface_3_min { get; set; }
        public double sizesurface_4_max { get; set; }
        public double sizesurface_4_min { get; set; }
        public double sizesurface_5_max { get; set; }
        public double sizesurface_5_min { get; set; }
        public double sizesurface_6_max { get; set; }
        public double sizesurface_6_min { get; set; }
        public double sizesurface_7_max { get; set; }
        public double sizesurface_7_min { get; set; }
        public double sizesurface_8_max { get; set; }
        public double sizesurface_8_min { get; set; }
        public double output_tolerance { get; set; }
        public double output_ra { get; set; }
        public double output_rmax { get; set; }
        public double output_s { get; set; }
        public double output_tp { get; set; }
        public double output_hrc { get; set; }
        public double output_depth { get; set; }
        public double output_internalstress_1 { get; set; }
        public double output_internalstress_2 { get; set; }
        public double output_internalstress_3 { get; set; }
        public string code_surface_stock { get; set; }
        public double input_tolerance { get; set; }
        public double input_ra { get; set; }
        public double input_rmax { get; set; }
        public double input_s { get; set; }
        public double input_tp { get; set; }
        public double input_hrc { get; set; }
        public double input_depth { get; set; }
        public double input_internalstress_1 { get; set; }
        public double input_internalstress_2 { get; set; }
        public double input_internalstress_3 { get; set; }
        public string mark_material { get; set; }
    }
}

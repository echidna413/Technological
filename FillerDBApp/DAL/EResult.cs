﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EResult
    {
        [Key]
        public int record_id { get; set; }
        public int device_id { get; set; }
        public double view_process { get; set; }
        public double code_surface_output { get; set; }
        public double code_surface_input { get; set; }
        public string mark_material { get; set; }
        public double size_surface_1_max { get; set; }
        public double size_surface_1_min { get; set; }
        public double size_surface_2_max { get; set; }
        public double size_surface_2_min { get; set; }
        public double size_surface_3_max { get; set; }
        public double size_surface_3_min { get; set; }
        public double size_surface_4_max { get; set; }
        public double size_surface_4_min { get; set; }
        public double size_surface_5_max { get; set; }
        public double size_surface_5_min { get; set; }
        public double size_surface_6_max { get; set; }
        public double size_surface_6_min { get; set; }
        public double size_surface_7_max { get; set; }
        public double size_surface_7_min { get; set; }
        public double size_surface_8_max { get; set; }
        public double size_surface_8_min { get; set; }
        public double max_output_tolerance { get; set; }
        public double min_output_tolerance { get; set; }
        public double max_output_ra { get; set; }
        public double min_output_ra { get; set; }
        public double max_output_rmax { get; set; }
        public double min_output_rmax { get; set; }
        public double max_output_s { get; set; }
        public double min_output_s { get; set; }
        public double max_output_tp { get; set; }
        public double min_output_tp { get; set; }
        public double max_output_hrc { get; set; }
        public double min_output_hrc { get; set; }
        public double max_output_depth { get; set; }
        public double min_output_depth { get; set; }
        public double max_output_internalstress_1 { get; set; }
        public double min_output_internalstress_1 { get; set; }
        public double max_output_internalstress_2 { get; set; }
        public double min_output_internalstress_2 { get; set; }
        public double max_output_internalstress_3 { get; set; }
        public double min_output_internalstress_3 { get; set; }
        public double max_input_tolerance { get; set; }
        public double min_input_tolerance { get; set; }
        public double max_input_ra { get; set; }
        public double min_input_ra { get; set; }
        public double max_input_rmax { get; set; }
        public double min_input_rmax { get; set; }
        public double max_input_s { get; set; }
        public double min_input_s { get; set; }
        public double max_input_tp { get; set; }
        public double min_input_tp { get; set; }
        public double max_input_hrc { get; set; }
        public double min_input_hrc { get; set; }
        public double max_input_depth { get; set; }
        public double min_input_depth { get; set; }
        public double max_input_internalstress_1 { get; set; }
        public double min_input_internalstress_1 { get; set; }
        public double max_input_internalstress_2 { get; set; }
        public double min_input_internalstress_2 { get; set; }
        public double max_input_internalstress_3 { get; set; }
        public double min_input_internalstress_3 { get; set; }
    }
}

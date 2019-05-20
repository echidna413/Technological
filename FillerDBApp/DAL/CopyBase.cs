﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CopyBase
    {
        [Key]
        public int id { get; set; }
        public double number_equipment { get; set; }
        public double number_base_surface { get; set; }
        public double code_surface { get; set; }
        public string com_1_tol { get; set; }
        public string com_2_tol { get; set; }
        public string com_3_tol { get; set; }
        public string com_4_tol { get; set; }
        public string com_5_tol { get; set; }
        public string com_6_tol { get; set; }
        public string com_7_tol { get; set; }
        public string com_8_tol { get; set; }
    }
}

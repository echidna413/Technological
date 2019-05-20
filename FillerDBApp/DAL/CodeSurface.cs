using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CodeSurface
    {
        [Key]
        public int code_surface_id { get; set; }
        public string code_surface { get; set; }
        public string description { get; set; }
        public string view_2d { get; set; }
        public string view_3d_small { get; set; }
        public string view_3d_big { get; set; }
    }
}

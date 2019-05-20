using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CodeSurfaceSize
    {
        [ForeignKey("code_surface_id")]
        public CodeSurface CodeSurface { get; set; }

        [Key]
        public int id { get; set; }
        public int code_surface_id { get; set; }
        public double size_number { get; set; }
        public double size_description_id { get; set; }
        public bool requremeint { get; set; }
    }
}

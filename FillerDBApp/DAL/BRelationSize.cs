using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BRelationSize
    {
        [ForeignKey("surface_id")]
        public BSurface BSurface { get; set; }

        [Key]
        public int relation_id { get; set; }
        public int surface_id { get; set; }
        public int relation_surface_id { get; set; }
        public double size { get; set; }
        public string tolerance { get; set; } //why string????????
        public double max_deviation { get; set; }
        public double min_deviation { get; set; }
    }
}

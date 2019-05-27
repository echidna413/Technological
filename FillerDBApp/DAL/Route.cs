using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Route
    {
        [ForeignKey("id_card")]
        public RouteCard RouteCard { get; set; }

        [ForeignKey("id")]
        public Operation Operation { get; set; }

        [ForeignKey("number_equipment")]
        public EDescription EDescription { get; set; }

        [Key]
        public int id_route { get; set; }
        public int id_card { get; set; }
        public int id{ get; set; } //id_operation
        public int numb_operation { get; set; }
        public int number_equipment { get; set; }
        public double t_base { get; set; }
        public double t_aux { get; set; }
        public double t_pf { get; set; }
        public double t_piece { get; set; }
    }
}

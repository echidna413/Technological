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
        public ELathe ELathe { get; set; }

        [Key]
        public int id_route { get; set; } 
        public int id_card { get; set; } // Маршрутная карта
        public int id{ get; set; } //id_operation
        public int numb_operation { get; set; } //Номер операции
        public int number_equipment { get; set; } //Номер оборудования (станок)
        public double t_aux { get; set; }//Вркмя ш.
        public double t_pf { get; set; } //Время п.з. 
    }
}

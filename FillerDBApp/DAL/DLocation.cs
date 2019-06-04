using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //Данный класс описывает сущность "Требования к взаимному расположению"
    public class DLocation
    {
        [ForeignKey("surface_id")]
        public DSurface DSurface { get; set; }


        [Key]
        public int location_id { get; set; }
        public int surface_id { get; set; } //Поверхность 
        public int relation_surface { get; set; } //Номер связной поверхности
        public int type_deviation { get; set; } // Вид отклонения
        public double limit_deviation { get; set; } //Предельное значение отклонения
    }
}

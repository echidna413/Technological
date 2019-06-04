using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //Данный класс описывает сущность "Размерные характеристики"
    public class DSizeSurface
    {
        [ForeignKey("surface_id")]
        public DSurface DSurface { get; set; }

        [Key]
        public int size_id { get; set; }
        public int surface_id { get; set; } //Базовая поверхность
        //Диаметр меньший
        public double min_size { get; set; } //Размер
        public double min_tolerance { get; set; } //Квалитет
        public double min_max_deviation { get; set; } //Максимальное отклонение
        public double min_min_deviation { get; set; } //Минимальное отклонение
        //Диаметр больший
        public double max_size { get; set; } //Размер
        public double max_tolerance { get; set; } //Квалитет
        public double max_max_deviation { get; set; } //Максимальное отклонение
        public double max_min_deviation { get; set; } //Минимальное отклонение


        //public int size_description_id { get; set; } 
        //public double nominal { get; set; }
        //public string finish { get; set; }
        //public double max_deviation { get; set; }
        //public double min_deviation { get; set; }
        //public double tolerance { get; set; }
        //public bool symmetry { get; set; }
    }
}

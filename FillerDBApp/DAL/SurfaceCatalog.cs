using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SurfaceCatalog
    {
        [Key]
        public int surface_code { get; set; }
        public string model { get; set; } //Код элементарной поверхности
        public string name { get; set; } //Название вида элементарной поверхности
        public string view_small { get; set; } //Малое изображение
        public string view_big { get; set; } //Большое изображение
    }
}

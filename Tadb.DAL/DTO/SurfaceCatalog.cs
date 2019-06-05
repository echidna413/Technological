using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tadb.DAL
{
    public class SurfaceCatalog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int surface_code { get; set; }

        public string model { get; set; } //Код элементарной поверхности
        public string name { get; set; } //Название вида элементарной поверхности
        public string view_small { get; set; } //Малое изображение
        public string view_big { get; set; } //Большое изображение
    }
}
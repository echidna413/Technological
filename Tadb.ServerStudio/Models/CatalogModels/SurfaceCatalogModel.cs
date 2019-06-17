using System.ComponentModel.DataAnnotations;

namespace Tadb.ServerStudio.Models.CatalogModels
{
    public class SurfaceCatalogModel
    {
        [Display(Name = "Код элементарной поверхности")]
        public int surface_code { get; set; }
        [Display(Name = "Модель")]
        public string model { get; set; } //Код элементарной поверхности
        [Display(Name = "Название вида элементарной поверхности")]
        public string name { get; set; } //Название вида элементарной поверхности
        //[Display(Name = "Малое изображение")]
        public string view_small { get; set; } //Малое изображение
        //[Display(Name = "Большое изображение")]
        public string view_big { get; set; } //Большое изображение
    }
}
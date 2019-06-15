using System.ComponentModel.DataAnnotations;

namespace Tadb.ServerStudio.Models.CatalogModels
{
    public class EquipmentCatalogModel
    {
        //[Display(Name = "Код оборудования")]
        public int equipment_code { get; set; }
        [Display(Name= "Модель оборудования")]
        public string model { get; set; } //Модель
        [Display(Name = "Описание")]
        public string description { get; set; } //Описание
    }
}
using System.ComponentModel.DataAnnotations;

namespace Tadb.ServerStudio.Models.CatalogModels
{
    public class FixtureCatalogModel
    {
        [Display(Name = "Код приспособления")]
        public int fixture_code { get; set; }
        [Display(Name = "Номер приспособления")]
        public string fixture_value { get; set; } //Номер приспособления
        [Display(Name = "Описание")]
        public string description { get; set; } //Описание
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    //Данный класс описывает сущность "Заготовка"
    public class BDescription
    {
        [ForeignKey("id_employee")]
        public virtual Employee Employee { get; set; }

        [Key]
        public int billet_id { get; set; }
        public int id_employee { get; set; } //Сотрудник, внесший запись
        public string name { get; set; } //Название заготовки
        public int code { get; set; } //Код заготовки
        public double size_production { get; set; } //Объем производственной партии
        public double size_transmission { get; set; } //Объем предаточной партии
        public bool central_hole { get; set; } //Возможность изготовления центрального отверстия
        public double mass_billet { get; set; } //Масса заготовки
        public double mark_material { get; set; } //Марка материала
        public string description { get; set; } //Примечание
    } 
}
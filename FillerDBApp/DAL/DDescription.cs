using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //Данный класс описывает сущность "Деталь"
    public class DDescription
    {
        [ForeignKey("id_employee")]
        public Employee Employee { get; set; }


        [Key]
        public int detail_id { get; set; }
        public int id_employee { get; set; } //Сотрудник, внесшую запись в бд
        public string code_detail { get; set; } //Код детали
        public string name_detail { get; set; } //Название детали
        public string mark_material { get; set; } //Марка материала
        public double size_production { get; set; } //Объем производственной партии
        public double size_transmission { get; set; } //Объем предаточной партии
        public double mass_detail { get; set; } //Масса детали
        public bool central_hole { get; set; } //Возможность изготовления центрального отверстия
        public string description { get; set; } //Примечание
    }
}

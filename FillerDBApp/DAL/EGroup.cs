using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //Данный клас описывает сущность "Группа оборудования"
    public class EGroup
    {
        [ForeignKey("id_employee")]
        public Employee Employee { get; set; }

        [Key]
        public int group_id { get; set; }
        public int id_employee { get; set; } //Сотрудник, занесший  бд данные
        public string name { get; set; } //Название группы
        public string description { get; set; } //Доп. сведения
    }
}

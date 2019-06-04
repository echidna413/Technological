using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //Данный класс описывает сущность "Схема базирования" для оборудования
    public class EBaseScheme
    {
        [ForeignKey("lathe_id")]
        public ELathe ELathe { get; set; }

        [Key]
        public int base_scheme_id { get; set; }
        public int lathe_id { get; set; } //Станок (Внешний ключ)
        public string name { get; set; } //Название схемы базирования
        public bool enabled { get; set; } //Работоспособность
        public string description { get; set; } //Доп. сведения
    }
}

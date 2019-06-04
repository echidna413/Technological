using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tadb.DAL
{
    //Данный класс описывает сущность "Станок"
    public class ELathe
    {
        [ForeignKey("group_id")]
        public EGroup EGroup { get; set; }

        [Key]
        public int lathe_id { get; set; }

        public int group_id { get; set; } //Группа оборудования(Внешний ключ)
        public string name { get; set; } //Название станка
        public string code { get; set; } // Код станка
        public bool enabled { get; set; } //Работоспособность
        public string description { get; set; }  //Доп. сведения
    }
}
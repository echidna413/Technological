using System.ComponentModel.DataAnnotations;

namespace Tadb.DAL
{
    //Данный класс описывает сущность "Операция"
    public class Operation
    {
        [Key]
        public int id { get; set; }

        public double number_operation { get; set; } //Номер операции
        public string name_operation { get; set; } //Название операции
    }
}
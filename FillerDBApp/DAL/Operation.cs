using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
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

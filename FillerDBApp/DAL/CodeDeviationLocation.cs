﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //Данный класс описывает сущность "Справочник отклонений от взаимного расположения"
    public class CodeDeviationLocation
    {
        [Key]
        public int code_geo_deviation_id { get; set; }
        public string type { get; set; } //Вид отклонения
        public string image { get; set; } //Изображение
    }
}
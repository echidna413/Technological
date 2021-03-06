﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //Данный класс описывает сущность "Базовая поверхность заготовки"
    public class BSurface
    {
        [ForeignKey("billet_id")]
        public BDescription BDescription { get; set; }

        [Key]
        public int surface_id { get; set; }
        public int billet_id { get; set; } //Заготовка
        public double number_surface { get; set; } //Номер поверхности на заготовке
        public int type_surface { get; set; } //Вид элементарной поверхности
        public int orientation { get; set; } //Ориентация поверхности
        //Координаты нулевой точки
        public double zero_point_X { get; set; } //Координата X
        public double zero_point_Y { get; set; } //Координата Y
        public double zero_point_Z { get; set; } //Координата Z
        //Шероховатость
        public double ra { get; set; } //Ra
        public double rmax { get; set; } //Rmax
        public double s { get; set; } //S
        public double tp { get; set; } //tp
        //Твердость
        public double hrc { get; set; } //HRC
        public double depth { get; set; } //Глубина наклепаного слоя 
        //Внутренние напряжения
        public double internal_stress_1 { get; set; } //Внутреннее напряжение X
        public double internal_stress_2 { get; set; } //Внутреннее напряжение Y
        public double internal_stress_3 { get; set; } //Внутреннее напряжение Z
        public bool constructor_base { get; set; } //Использование в качестве конструкторской базы
    }
}

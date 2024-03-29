﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //Данный класс описывает сущность "Справочник оборудования"
    public class EquipmentCatalog
    {
        [Key]
        public int equipment_code { get; set; }
        public string model { get; set; } //Модель
        public string description { get; set; } //Описание

        public override bool Equals(object obj)
        {
            var catalog = obj as EquipmentCatalog;
            return catalog != null &&
                   model == catalog.model &&
                   description == catalog.description;
        }

        public override int GetHashCode()
        {
            var hashCode = -1046445613;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(model);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(description);
            return hashCode;
        }
    }
}

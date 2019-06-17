using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tadb.DAL
{
    public class FixtureCatalog
    {
        //Данный класс описывает сущность "Справочник приспособлений"
        [Key]
        public int fixture_code { get; set; }
        [Index(IsUnique = true)]
        [StringLength(200)]
        public string fixture_value { get; set; } //Номер приспособления
        public string description { get; set; } //Описание

        public override bool Equals(object obj)
        {
            var catalog = obj as FixtureCatalog;
            return catalog != null &&
                   fixture_value == catalog.fixture_value &&
                   description == catalog.description;
        }

        public override int GetHashCode()
        {
            var hashCode = -1045668907;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(fixture_value);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(description);
            return hashCode;
        }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tadb.DAL
{
    //Данный класс описывает сущность "Справочник обработки"
    public class ProcessCatalog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int process_code { get; set; }

        public string description { get; set; } //Описание

        public override bool Equals(object obj)
        {
            var catalog = obj as ProcessCatalog;
            return catalog != null &&
                   description == catalog.description;
        }

        public override int GetHashCode()
        {
            var hashCode = 1148760679;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(description);
            return hashCode;
        }
    }
}
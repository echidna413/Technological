using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tadb.DAL
{
    public class SurfaceCatalog
    {
        [Key]
        public int surface_code { get; set; }
        [Index(IsUnique = true)]
        [StringLength(200)]
        public string model { get; set; } // Модель элементарной поверхности
        public string name { get; set; } //Название вида элементарной поверхности
        public string view_small { get; set; } //Малое изображение
        public string view_big { get; set; } //Большое изображение

        public override bool Equals(object obj)
        {
            return obj is SurfaceCatalog catalog &&
                   surface_code == catalog.surface_code &&
                   model == catalog.model &&
                   name == catalog.name &&
                   view_small == catalog.view_small &&
                   view_big == catalog.view_big;
        }

        public override int GetHashCode()
        {
            var hashCode = -1560266395;
            hashCode = hashCode * -1521134295 + surface_code.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(model);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(view_small);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(view_big);
            return hashCode;
        }
    }
}
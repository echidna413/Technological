using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tadb.DAL
{
    //Данный класс описывает сущность "Размерные связи"
    public class DRelationSize
    {
        [ForeignKey("surface_id")]
        public DSurface DSurface { get; set; }

        [Key]
        public int relation_id { get; set; }

        public int surface_id { get; set; } //Базовая поверхность
        public int relation_number { get; set; } //Номер связанной поверхности
        public double size { get; set; } //Номинальный размер
        public string tolerance { get; set; } //Квалитет
        public double min_deviation { get; set; } //Верхнее предельное отклонение
        public double max_deviation { get; set; } //Нижнее предельное отклонение
    }
}
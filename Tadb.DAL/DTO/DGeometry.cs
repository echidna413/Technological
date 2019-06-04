using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tadb.DAL
{
    public class DGeometry
    {
        [ForeignKey("surface_id")]
        public DSurface DSurface { get; set; }

        [Key]
        public int deviation_id { get; set; }

        public int surface_id { get; set; } //Базовая поверхность
        public int type_deviation { get; set; } //Вид отклонения
        public double class_deviation { get; set; } //Класс
        public double value_deviation { get; set; } //Значение
    }
}
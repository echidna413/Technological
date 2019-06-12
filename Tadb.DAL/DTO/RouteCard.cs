using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tadb.DAL
{
    public class RouteCard
    {
        //Данный класс описывает сущность "Маршрутная карта"

        [ForeignKey("detail_id")]
        public DDescription DDescription { get; set; }

        [ForeignKey("billet_id")]
        public BDescription BDescription { get; set; }

        [Key]
        public int id_card { get; set; }

        public string name_card { get; set; } //Название карты
        public int? detail_id { get; set; } //Деталь
        public int? billet_id { get; set; } //Заготовка
        public int? profile_sizes { get; set; } //Профиль и размеры
        public string link { get; set; } //путь расположения файла
    }
}
using System.ComponentModel.DataAnnotations;

namespace Tadb.DAL
{
    //Данный класс описывает сущность "Роль Сотрудника"
    public class Role
    {
        [Key]
        public int id_role { get; set; }

        public string name { get; set; } //Название роли
        public bool canEnter { get; set; } //Добавление записи технологических возмжностей
        public bool canGetData { get; set; } //Просмотр записи технологических возможностей
        public bool canEdit { get; set; } //Изменение записи (статуса)
        public bool canEditCatalog { get; set; } //Формирование маршрутной карты
    }
}
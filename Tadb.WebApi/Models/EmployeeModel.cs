using Tadb.DAL;

namespace Tadb.WebApi.Models
{
    public class EmployeeModel
    {
        public int id_employee { get; set; }

        public int id_role { get; set; }
        public int id_company { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
        public string patronymic { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public Role Role { get; set; }
        public Company Company { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tadb.DAL
{
    public class Employee
    {
        public Employee()
        {
        }

        //public Employee(int id_employee, int id_role, int id_company, string first_name, string second_name, string patronymic, string login, string password, Role role, Company company)
        //{
        //    this.id_employee = id_employee;
        //    this.id_role = id_role;
        //    this.id_company = id_company;
        //    this.first_name = first_name;
        //    this.second_name = second_name;
        //    this.patronymic = patronymic;
        //    this.login = login;
        //    this.passwordHash = password;
        //    Role = role;
        //    Company = company;
        //}

        [Key]
        public int id_employee { get; set; }

        public int id_role { get; set; }
        public int id_company { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
        public string patronymic { get; set; }
        public string login { get; set; }
        public virtual string passwordHash { get; set; }

        [ForeignKey("id_role")]
        public Role Role { get; set; }

        [ForeignKey("id_company")]
        public Company Company { get; set; }

        public override bool Equals(object obj)
        {
            var employee = obj as Employee;
            return employee != null &&
                   id_employee == employee.id_employee &&
                   id_role == employee.id_role &&
                   id_company == employee.id_company &&
                   first_name == employee.first_name &&
                   second_name == employee.second_name &&
                   patronymic == employee.patronymic &&
                   login == employee.login &&
                   passwordHash == employee.passwordHash &&
                   EqualityComparer<Role>.Default.Equals(Role, employee.Role) &&
                   EqualityComparer<Company>.Default.Equals(Company, employee.Company);
        }

        public override int GetHashCode()
        {
            var hashCode = 323922702;
            hashCode = hashCode * -1521134295 + id_employee.GetHashCode();
            hashCode = hashCode * -1521134295 + id_role.GetHashCode();
            hashCode = hashCode * -1521134295 + id_company.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(first_name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(second_name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(patronymic);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(login);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(passwordHash);
            hashCode = hashCode * -1521134295 + EqualityComparer<Role>.Default.GetHashCode(Role);
            hashCode = hashCode * -1521134295 + EqualityComparer<Company>.Default.GetHashCode(Company);
            return hashCode;
        }
    }
}
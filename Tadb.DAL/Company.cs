using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tadb.DAL
{
    //Данный класс описывает сущность "Предприятие"
    public class Company
    {
        [Key]
        public int id_company { get; set; }

        public int responsible_employee { get; set; } //Представитель компании
        public int numberof_branch { get; set; } //Номер филиала
        public string name { get; set; } //Название компании
        public string address { get; set; } //Адрес комапнии

        public override bool Equals(object obj)
        {
            var company = obj as Company;
            return company != null &&
                   id_company == company.id_company &&
                   responsible_employee == company.responsible_employee &&
                   numberof_branch == company.numberof_branch &&
                   name == company.name &&
                   address == company.address;
        }

        public override int GetHashCode()
        {
            var hashCode = -216774429;
            hashCode = hashCode * -1521134295 + id_company.GetHashCode();
            hashCode = hashCode * -1521134295 + responsible_employee.GetHashCode();
            hashCode = hashCode * -1521134295 + numberof_branch.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(address);
            return hashCode;
        }
    }
}
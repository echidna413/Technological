using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Tadb.Common;
using Tadb.DAL;

namespace Tadb.BL
{
    public class AutorizationService
    {
        private string HashPassword(string password)
        {
            StringBuilder hashedPasswordStringBuilder;
            using (SHA512 m = new SHA512Managed())
            {
                var passwordBytes = Encoding.UTF8.GetBytes(password);
                var hashedPasswordBytes = m.ComputeHash(passwordBytes);

                hashedPasswordStringBuilder = new StringBuilder(128);
                foreach (var b in hashedPasswordBytes)
                    hashedPasswordStringBuilder.Append(b.ToString("X2"));
            }
            return hashedPasswordStringBuilder.ToString();
        }

        public bool Authorize(string login, string password)
        {
            string hashedPassword = this.HashPassword(password);

            Employee foundUser = null;
            string role;
            using (MachineDbContext context = new MachineDbContext())
            {
                foundUser = context.Employees.FirstOrDefault(x => x.login.Equals(login));
                role = foundUser.Role.name;
                if (foundUser is null)
                {
                    throw new Exception("Пользователя с таким логином не существует");
                }
            }

            bool isEqual = foundUser.passwordHash.ToUpper().Equals(hashedPassword.ToUpper());
            if (!isEqual)
            {
                throw new Exception("Неверный пароль");
            }

            ApplicationData.Instance.Login = login;
            ApplicationData.Instance.Role = role;
            return true;
        }

        public void CreateNewUser(Role role,
                                  Company company,
                                  string first_name,
                                  string second_name,
                                  string patronymic,
                                  string login,
                                  string password)
        {
            string hashedPassword = this.HashPassword(password);

            Employee foundUser = null;
            using (MachineDbContext context = new MachineDbContext())
            {
                foundUser = context.Employees.FirstOrDefault(x => x.login.Equals(login));
                if (!(foundUser is null))
                {
                    throw new Exception("Пользователь с таким логином существует");
                }

                Employee newUser = new Employee()
                {
                    Role = role,
                    Company = company,
                    first_name = first_name,
                    second_name = second_name,
                    patronymic = patronymic,
                    login = login,
                    passwordHash = hashedPassword
                };

                context.Employees.Add(newUser);
                context.SaveChanges();
            }
        }

        public Employee GetEmployeeByLoginPassword(string login, string password)
        {
            string hashedPassword = this.HashPassword(password);

            Employee foundEmployee = null;
            string role;
            using (MachineDbContext context = new MachineDbContext())
            {
                foundEmployee = context.Employees
                    .Include("Role")
                    .FirstOrDefault(x => x.login.Equals(login));
                role = foundEmployee.Role.name;
                if (foundEmployee is null)
                {
                    throw new Exception("Пользователя с таким логином не существует");
                }
            }

            bool isEqual = foundEmployee.passwordHash.ToUpper().Equals(hashedPassword.ToUpper());
            if (!isEqual)
            {
                throw new Exception("Неверный пароль");
            }

            return foundEmployee;
        }
    }
}
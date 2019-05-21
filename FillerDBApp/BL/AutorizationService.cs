using Common;
using DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AutorizationService
    {

        string HashPassword(string password)
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

            bool isEqual = foundUser.password.ToUpper().Equals(hashedPassword.ToUpper());
            if (!isEqual)
            {
                throw new Exception("Неверный пароль");
            }

            ApplicationData.Instance.Login = login;
            ApplicationData.Instance.Role = role;
            return true;

        }

        public void CreateNewUser(string user, string password, Role role)
        {
            string hashedPassword = this.HashPassword(password);

            Employee foundUser = null;
            using (MachineDbContext context = new MachineDbContext())
            {
                foundUser = context.Employees.FirstOrDefault(x => x.login.Equals(user));
                if (!(foundUser is null))
                {
                    throw new Exception("Пользователь с таким логином существует");
                }

                Employee newUser = new Employee()
                {
                    login = user,
                    password = hashedPassword,
                    Role = role,
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

            bool isEqual = foundEmployee.password.ToUpper().Equals(hashedPassword.ToUpper());
            if (!isEqual)
            {
                throw new Exception("Неверный пароль");
            }

            return foundEmployee;
        }
    }
}

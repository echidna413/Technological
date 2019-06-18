using System.Data.Entity.Migrations;
using System.Security.Cryptography;
using System.Text;

namespace Tadb.DAL.Migrations.DataInitializator
{
    internal class DataSeeder
    {
        private DataSeeder()
        {
        }

        public static DataSeeder Instance { get; } = new DataSeeder();

        public void Init(MachineDbContext context)
        {
            SeedRoles(context);
            SeedCompanies(context);
            SeedEmployees(context);
            SeedStatuses(context);

            context.SaveChanges();
        }

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

        private void SeedEmployees(MachineDbContext context)
        {
            string adminPassword = "12345";

            Employee rootAdmin = new Employee
            {
                id_employee = 1,
                id_role = 1,
                id_company = 1,
                first_name = "Иван",
                second_name = "Иванов",
                patronymic = "Иванович",
                login = "admin",
                passwordHash = HashPassword(adminPassword),
            };

            context.Employees.AddOrUpdate(rootAdmin);
        }

        private static void SeedCompanies(MachineDbContext context)
        {
            Company devCompany = new Company
            {
                id_company = 1,
                responsible_employee = 1,
                numberof_branch = 1,
                name = "СГТУ",
                address = "Саратов, ул. Политехническая, 77"
            };

            context.Companies.AddOrUpdate(devCompany);
        }

        private static void SeedRoles(MachineDbContext context)
        {
            Role[] roles = new[]
            {
                new Role
                {
                    id_role = 1,
                    name = "Администратор",
                    canEnter = true,
                    canGetData = true,
                    canEdit = true,
                    canEditCatalog = true
                },
            };

            context.Roles.AddOrUpdate(roles);
        }

        private static void SeedStatuses(MachineDbContext context)
        {
            Status[] statuses = new[]
            {
                new Status
                {
                    id_status = 1,
                    name = "На проверку"
                },
                new Status
                {
                    id_status = 2,
                    name = "Проверено"
                },
                new Status
                {
                    id_status = 3,
                    name = "Отклонено"
                },
                new Status
                {
                    id_status = 4,
                    name = "Устарело"
                },
            };

            context.Statuses.AddOrUpdate(statuses);
        }
    }
}
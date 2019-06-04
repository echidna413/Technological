namespace Tadb.DAL.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Security.Cryptography;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<Tadb.DAL.MachineDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
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

        protected override void Seed(Tadb.DAL.MachineDbContext context)
        {
            SeedRoles(context);
            SeedCompanies(context);
            SeedEmployees(context);
            context.SaveChanges();

        }

        private void SeedEmployees(MachineDbContext context)
        {
            string adminPassword = "12345";

            Employee rootAdmin = new Employee
            {
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
                address = "Саратов, Политехническая, 77"
            };

            context.Companies.AddOrUpdate(devCompany);

            #region Место для добавление компаний
            //Company[] companies = new Company[]
            //{
            //    new Company()
            //    {
            //        id_company = 1,
            //        responsible_employee= 1,
            //        numberof_branch= 1,
            //        name = "ТрансНефтеМаш",
            //        address = "Улица Пушкина, дом Колотушкина"
            //    },
            //    new Company()
            //    {
            //        id_company = 2,
            //        responsible_employee= 2,
            //        numberof_branch= 1,
            //        name = "Челябинский Металлург",
            //        address = "Улица Пушкина, дом Колотушкина"
            //    },
            //    new Company()
            //    {
            //        id_company = 2,
            //        responsible_employee= 5,
            //        numberof_branch= 2,
            //        name = "Челябинский Металлург",
            //        address = "Улица Пушкина, дом 1"
            //    }
            //};

            //context.Companies.AddOrUpdate(companies); 
            #endregion
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
                new Role
                {
                    id_role = 2,
                    name = "Технолог по базе возможностей",
                    canEnter = true,
                    canGetData = true,
                    canEdit = false,
                    canEditCatalog = false
                },
                new Role
                {
                    id_role = 3,
                    name = "Технолог по базе деталей",
                    canEnter = false,
                    canGetData = false,
                    canEdit = false,
                    canEditCatalog = true
                }
            };

            context.Roles.AddOrUpdate(roles);
        }
    }
}
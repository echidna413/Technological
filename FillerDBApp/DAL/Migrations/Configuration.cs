namespace DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.MachineDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DAL.MachineDbContext context)
        {
            Role role1 = new Role
            {
                name = "Администратор",
                canEnter = true,
                canGetData = true,
                canEdit = true,
                canEditCatalog = true
            };
            Role role2 = new Role
            {
                name = "Технолог по базе возможностей",
                canEnter = true,
                canGetData = true,
                canEdit = false,
                canEditCatalog = false
            };
            Role role3 = new Role
            {
                name = "Технолог по базе деталей",
                canEnter = false,
                canGetData = false,
                canEdit = false,
                canEditCatalog = true
            };
            Company devCompany = new Company
            {
                id_company = 1,
                responsible_employee = 1,
                numberof_branch = 1,
                name = "СГТУ",
                address = "Саратов, Политехническая, 77"
            };
            //Employee rootAdmin = new Employee
            //{
            //    id_role = 1,
            //    id_company = 8,
            //    first_name = "Иван",
            //    second_name = "Иванов",
            //    patronymic = "Иванович",
            //    login = "admin",
            //    password = "30bb8411dd0cbf96b10a52371f7b3be1690f7afa16c3bd7bc7d02c0e2854768d",
            //};

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
            context.Roles.Add(role1);
            context.Roles.Add(role2);
            context.Roles.Add(role3);
            context.Companies.AddOrUpdate(devCompany);
            //context.Employees.AddOrUpdate(rootAdmin);
            context.SaveChanges();
        }
    }
}
    

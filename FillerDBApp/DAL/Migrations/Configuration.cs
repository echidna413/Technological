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
            Company[] companies = new Company[]
            {
                new Company()
                {
                    id_company = 1,
                    responsible_employee= 1,
                    numberof_branch= 1,
                    name = "ТрансНефтеМаш",
                    address = "Улица Пушкина, дом Колотушкина"
                },
                new Company()
                {
                    id_company = 2,
                    responsible_employee= 2,
                    numberof_branch= 1,
                    name = "Челябинский Металлург",
                    address = "Улица Пушкина, дом Колотушкина"
                },
                new Company()
                {
                    id_company = 2,
                    responsible_employee= 5,
                    numberof_branch= 2,
                    name = "Челябинский Металлург",
                    address = "Улица Пушкина, дом 1"
                }
            };
            
            context.Companies.AddOrUpdate(companies);
            context.SaveChanges();
        }
    }
}

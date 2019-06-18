namespace Tadb.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Tadb.DAL.Migrations.DataInitializator;

    internal sealed class Configuration : DbMigrationsConfiguration<Tadb.DAL.MachineDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Tadb.DAL.MachineDbContext context)
        {
            DataSeeder.Instance.Init(context);
        }
    }
}

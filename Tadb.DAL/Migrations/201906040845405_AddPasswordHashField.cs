namespace Tadb.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPasswordHashField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "passwordHash", c => c.String());
            DropColumn("dbo.Employees", "password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "password", c => c.String());
            DropColumn("dbo.Employees", "passwordHash");
        }
    }
}

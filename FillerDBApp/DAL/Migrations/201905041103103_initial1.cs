namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BDescriptions", "id_employee", c => c.Int(nullable: false));
            AddColumn("dbo.DDescriptions", "id_employee", c => c.Int(nullable: false));
            AddColumn("dbo.EDescriptions", "id_employee", c => c.Int(nullable: false));
            CreateIndex("dbo.BDescriptions", "id_employee");
            CreateIndex("dbo.DDescriptions", "id_employee");
            CreateIndex("dbo.EDescriptions", "id_employee");
            AddForeignKey("dbo.BDescriptions", "id_employee", "dbo.Employees", "id_employee", cascadeDelete: true);
            AddForeignKey("dbo.DDescriptions", "id_employee", "dbo.Employees", "id_employee", cascadeDelete: true);
            AddForeignKey("dbo.EDescriptions", "id_employee", "dbo.Employees", "id_employee", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EDescriptions", "id_employee", "dbo.Employees");
            DropForeignKey("dbo.DDescriptions", "id_employee", "dbo.Employees");
            DropForeignKey("dbo.BDescriptions", "id_employee", "dbo.Employees");
            DropIndex("dbo.EDescriptions", new[] { "id_employee" });
            DropIndex("dbo.DDescriptions", new[] { "id_employee" });
            DropIndex("dbo.BDescriptions", new[] { "id_employee" });
            DropColumn("dbo.EDescriptions", "id_employee");
            DropColumn("dbo.DDescriptions", "id_employee");
            DropColumn("dbo.BDescriptions", "id_employee");
        }
    }
}

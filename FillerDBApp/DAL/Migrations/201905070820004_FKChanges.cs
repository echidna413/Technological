namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BDescriptions", "id_company", c => c.Int(nullable: false));
            AddColumn("dbo.DDescriptions", "id_company", c => c.Int(nullable: false));
            AddColumn("dbo.EDescriptions", "id_company", c => c.Int(nullable: false));
            CreateIndex("dbo.BDescriptions", "id_company");
            CreateIndex("dbo.DDescriptions", "id_company");
            CreateIndex("dbo.EDescriptions", "id_company");
            AddForeignKey("dbo.BDescriptions", "id_company", "dbo.Companies", "id_company", cascadeDelete: false);
            AddForeignKey("dbo.DDescriptions", "id_company", "dbo.Companies", "id_company", cascadeDelete: false);
            AddForeignKey("dbo.EDescriptions", "id_company", "dbo.Companies", "id_company", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EDescriptions", "id_company", "dbo.Companies");
            DropForeignKey("dbo.DDescriptions", "id_company", "dbo.Companies");
            DropForeignKey("dbo.BDescriptions", "id_company", "dbo.Companies");
            DropIndex("dbo.EDescriptions", new[] { "id_company" });
            DropIndex("dbo.DDescriptions", new[] { "id_company" });
            DropIndex("dbo.BDescriptions", new[] { "id_company" });
            DropColumn("dbo.EDescriptions", "id_company");
            DropColumn("dbo.DDescriptions", "id_company");
            DropColumn("dbo.BDescriptions", "id_company");
        }
    }
}

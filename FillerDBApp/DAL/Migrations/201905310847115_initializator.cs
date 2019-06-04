namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initializator : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RouteCards",
                c => new
                    {
                        id_card = c.Int(nullable: false, identity: true),
                        id_company = c.Int(),
                        id_employee = c.Int(),
                    })
                .PrimaryKey(t => t.id_card)
                .ForeignKey("dbo.Companies", t => t.id_company)
                .ForeignKey("dbo.Employees", t => t.id_employee)
                .Index(t => t.id_company)
                .Index(t => t.id_employee);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        id_route = c.Int(nullable: false, identity: true),
                        id_card = c.Int(nullable: false),
                        id = c.Int(nullable: false),
                        numb_operation = c.Int(nullable: false),
                        number_equipment = c.Int(nullable: false),
                        t_base = c.Double(nullable: false),
                        t_aux = c.Double(nullable: false),
                        t_pf = c.Double(nullable: false),
                        t_piece = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id_route)
                .ForeignKey("dbo.EDescriptions", t => t.number_equipment, cascadeDelete: true)
                .ForeignKey("dbo.Operations", t => t.id, cascadeDelete: true)
                .ForeignKey("dbo.RouteCards", t => t.id_card, cascadeDelete: true)
                .Index(t => t.id_card)
                .Index(t => t.id)
                .Index(t => t.number_equipment);
            
            AddColumn("dbo.BDescriptions", "name", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Routes", "id_card", "dbo.RouteCards");
            DropForeignKey("dbo.Routes", "id", "dbo.Operations");
            DropForeignKey("dbo.Routes", "number_equipment", "dbo.EDescriptions");
            DropForeignKey("dbo.RouteCards", "id_employee", "dbo.Employees");
            DropForeignKey("dbo.RouteCards", "id_company", "dbo.Companies");
            DropIndex("dbo.Routes", new[] { "number_equipment" });
            DropIndex("dbo.Routes", new[] { "id" });
            DropIndex("dbo.Routes", new[] { "id_card" });
            DropIndex("dbo.RouteCards", new[] { "id_employee" });
            DropIndex("dbo.RouteCards", new[] { "id_company" });
            DropColumn("dbo.BDescriptions", "name");
            DropTable("dbo.Routes");
            DropTable("dbo.RouteCards");
        }
    }
}

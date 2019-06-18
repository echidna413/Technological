namespace Tadb.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inc : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Records", "bil_surfaceCode", "dbo.SurfaceCatalogs");
            DropForeignKey("dbo.Records", "surface_code", "dbo.SurfaceCatalogs");
            DropForeignKey("dbo.Records", "fbs_surfaceCode", "dbo.SurfaceCatalogs");
            DropForeignKey("dbo.Records", "sbs_surfaceCode", "dbo.SurfaceCatalogs");
            DropForeignKey("dbo.Records", "tbs_surfaceCode", "dbo.SurfaceCatalogs");
            DropPrimaryKey("dbo.SurfaceCatalogs");
            AddColumn("dbo.RouteCards", "employee", c => c.String());
            AddColumn("dbo.RouteCards", "link", c => c.String());
            AlterColumn("dbo.SurfaceCatalogs", "surface_code", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.SurfaceCatalogs", "model", c => c.String(maxLength: 200));
            AlterColumn("dbo.FixtureCatalogs", "fixture_value", c => c.String(maxLength: 200));
            AlterColumn("dbo.RouteCards", "profile_sizes", c => c.Int());
            AddPrimaryKey("dbo.SurfaceCatalogs", "surface_code");
            CreateIndex("dbo.SurfaceCatalogs", "model", unique: true);
            CreateIndex("dbo.FixtureCatalogs", "fixture_value", unique: true);
            AddForeignKey("dbo.Records", "bil_surfaceCode", "dbo.SurfaceCatalogs", "surface_code");
            AddForeignKey("dbo.Records", "surface_code", "dbo.SurfaceCatalogs", "surface_code");
            AddForeignKey("dbo.Records", "fbs_surfaceCode", "dbo.SurfaceCatalogs", "surface_code");
            AddForeignKey("dbo.Records", "sbs_surfaceCode", "dbo.SurfaceCatalogs", "surface_code");
            AddForeignKey("dbo.Records", "tbs_surfaceCode", "dbo.SurfaceCatalogs", "surface_code");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Records", "tbs_surfaceCode", "dbo.SurfaceCatalogs");
            DropForeignKey("dbo.Records", "sbs_surfaceCode", "dbo.SurfaceCatalogs");
            DropForeignKey("dbo.Records", "fbs_surfaceCode", "dbo.SurfaceCatalogs");
            DropForeignKey("dbo.Records", "surface_code", "dbo.SurfaceCatalogs");
            DropForeignKey("dbo.Records", "bil_surfaceCode", "dbo.SurfaceCatalogs");
            DropIndex("dbo.FixtureCatalogs", new[] { "fixture_value" });
            DropIndex("dbo.SurfaceCatalogs", new[] { "model" });
            DropPrimaryKey("dbo.SurfaceCatalogs");
            AlterColumn("dbo.RouteCards", "profile_sizes", c => c.Int(nullable: false));
            AlterColumn("dbo.FixtureCatalogs", "fixture_value", c => c.String());
            AlterColumn("dbo.SurfaceCatalogs", "model", c => c.String());
            AlterColumn("dbo.SurfaceCatalogs", "surface_code", c => c.Int(nullable: false));
            DropColumn("dbo.RouteCards", "link");
            DropColumn("dbo.RouteCards", "employee");
            AddPrimaryKey("dbo.SurfaceCatalogs", "surface_code");
            AddForeignKey("dbo.Records", "tbs_surfaceCode", "dbo.SurfaceCatalogs", "surface_code");
            AddForeignKey("dbo.Records", "sbs_surfaceCode", "dbo.SurfaceCatalogs", "surface_code");
            AddForeignKey("dbo.Records", "fbs_surfaceCode", "dbo.SurfaceCatalogs", "surface_code");
            AddForeignKey("dbo.Records", "surface_code", "dbo.SurfaceCatalogs", "surface_code");
            AddForeignKey("dbo.Records", "bil_surfaceCode", "dbo.SurfaceCatalogs", "surface_code");
        }
    }
}

namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeClasses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Records", "Status_id_status", c => c.Int());
            CreateIndex("dbo.Records", "Status_id_status");
            AddForeignKey("dbo.Records", "Status_id_status", "dbo.Status", "id_status");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Records", "Status_id_status", "dbo.Status");
            DropIndex("dbo.Records", new[] { "Status_id_status" });
            DropColumn("dbo.Records", "Status_id_status");
        }
    }
}

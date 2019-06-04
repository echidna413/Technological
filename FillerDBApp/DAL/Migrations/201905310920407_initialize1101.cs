namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialize1101 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RouteCards", "name_card", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RouteCards", "name_card");
        }
    }
}

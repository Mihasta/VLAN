namespace BugTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LAN1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Error", "ErrorStatus", c => c.Int(nullable: false));
            DropColumn("dbo.Error", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Error", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Error", "ErrorStatus");
        }
    }
}

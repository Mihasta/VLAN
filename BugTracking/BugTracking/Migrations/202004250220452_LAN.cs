namespace BugTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LAN : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Error", "Status", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Error", "Status", c => c.String());
        }
    }
}

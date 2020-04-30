namespace BugTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LAN : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "Like", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Like", c => c.Int(nullable: false));
        }
    }
}

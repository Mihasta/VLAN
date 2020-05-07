namespace BugTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LAN : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Like", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Like");
        }
    }
}

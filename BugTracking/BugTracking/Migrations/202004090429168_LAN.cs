namespace BugTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LAN : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Solution", "Likes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Solution", "Likes");
        }
    }
}

namespace BugTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LAN : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Solution", "LikedUsersId", c => c.String());
            DropColumn("dbo.User", "Like");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "Like", c => c.String());
            DropColumn("dbo.Solution", "LikedUsersId");
        }
    }
}

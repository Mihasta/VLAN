namespace BugTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LAN : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Error",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Date = c.DateTime(nullable: false),
                    Priority = c.Int(nullable: false),
                    Level = c.Int(nullable: false),
                    Code = c.String(),
                    Description = c.String(),
                    UserId = c.Int(nullable: false),
                    TypeId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ErrorType", t => t.TypeId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.TypeId);

            CreateTable(
                "dbo.ErrorType",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.User",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Surname = c.String(),
                    Login = c.String(),
                    Password = c.String(),
                    Status = c.Int(nullable: false),
                    Mail = c.String(),
                    PhoneNumber = c.String(maxLength: 12),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Solution",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Description = c.String(),
                    ErrorId = c.Int(nullable: false),
                    UserId = c.Int(nullable: false),
                    Date = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Error", t => t.ErrorId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: false)
                .Index(t => t.ErrorId)
                .Index(t => t.UserId);

            CreateTable(
                "dbo.Report",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Description = c.String(),
                    Date = c.DateTime(nullable: false),
                    ErrorId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Error", t => t.ErrorId, cascadeDelete: true)
                .Index(t => t.ErrorId);
            AddColumn("dbo.Solution", "Likes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Report", "ErrorId", "dbo.Error");
            DropForeignKey("dbo.Solution", "UserId", "dbo.User");
            DropForeignKey("dbo.Solution", "ErrorId", "dbo.Error");
            DropForeignKey("dbo.Error", "UserId", "dbo.User");
            DropForeignKey("dbo.Error", "TypeId", "dbo.ErrorType");
            DropIndex("dbo.Report", new[] { "ErrorId" });
            DropIndex("dbo.Solution", new[] { "UserId" });
            DropIndex("dbo.Solution", new[] { "ErrorId" });
            DropIndex("dbo.Error", new[] { "TypeId" });
            DropIndex("dbo.Error", new[] { "UserId" });
            DropTable("dbo.Report");
            DropTable("dbo.Solution");
            DropTable("dbo.User");
            DropTable("dbo.ErrorType");
            DropTable("dbo.Error");
            DropColumn("dbo.Solution", "Likes");
        }
    }
}

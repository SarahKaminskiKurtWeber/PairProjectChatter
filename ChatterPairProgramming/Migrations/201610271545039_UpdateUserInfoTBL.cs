namespace ChatterPairProgramming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserInfoTBL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Followers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.UserInfoes", "Password", c => c.String());
            AddColumn("dbo.UserInfoes", "FollowerID", c => c.Int(nullable: false));
            CreateIndex("dbo.UserInfoes", "FollowerID");
            AddForeignKey("dbo.UserInfoes", "FollowerID", "dbo.Followers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInfoes", "FollowerID", "dbo.Followers");
            DropIndex("dbo.UserInfoes", new[] { "FollowerID" });
            DropColumn("dbo.UserInfoes", "FollowerID");
            DropColumn("dbo.UserInfoes", "Password");
            DropTable("dbo.Followers");
        }
    }
}

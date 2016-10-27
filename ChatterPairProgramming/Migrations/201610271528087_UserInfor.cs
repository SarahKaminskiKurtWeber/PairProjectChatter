namespace ChatterPairProgramming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserInfor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserInfoes", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserInfoes", "UserName");
        }
    }
}

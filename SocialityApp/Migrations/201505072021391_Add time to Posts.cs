namespace SocialityApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtimetoPosts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Time", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Time");
        }
    }
}

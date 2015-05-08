namespace SocialityApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTitletoPostsmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Title");
        }
    }
}

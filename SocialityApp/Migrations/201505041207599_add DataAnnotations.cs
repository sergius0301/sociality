namespace SocialityApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Posts", "Description", c => c.String(nullable: false, maxLength: 2000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Description", c => c.String());
            AlterColumn("dbo.Posts", "Title", c => c.String());
        }
    }
}

namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesAddedSlug : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Slug", c => c.String(nullable: false, maxLength: 200));
            AddColumn("dbo.Jobs", "Slug", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Candidates", "Slug", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Employers", "Slug", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Teams", "Slug", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "Slug");
            DropColumn("dbo.Employers", "Slug");
            DropColumn("dbo.Candidates", "Slug");
            DropColumn("dbo.Jobs", "Slug");
            DropColumn("dbo.Blogs", "Slug");
        }
    }
}

namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogViewDateAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogReviews", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BlogReviews", "Date");
        }
    }
}

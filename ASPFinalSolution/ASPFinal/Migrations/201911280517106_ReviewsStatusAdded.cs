namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReviewsStatusAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogReviews", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.EmployerReviews", "Satuts", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployerReviews", "Satuts");
            DropColumn("dbo.BlogReviews", "Status");
        }
    }
}

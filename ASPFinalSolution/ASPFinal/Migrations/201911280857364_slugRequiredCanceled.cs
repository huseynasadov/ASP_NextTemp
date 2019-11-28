namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class slugRequiredCanceled : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Candidates", "Slug", c => c.String(maxLength: 100));
            AlterColumn("dbo.Employers", "Slug", c => c.String(maxLength: 100));
            AlterColumn("dbo.Employers", "CreatedAt", c => c.DateTime());
            AlterColumn("dbo.Teams", "Slug", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teams", "Slug", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Employers", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Employers", "Slug", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Candidates", "Slug", c => c.String(nullable: false, maxLength: 100));
        }
    }
}

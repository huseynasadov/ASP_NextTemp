namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CandidateWebsiteLenghtChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Candidates", "Country", c => c.String(maxLength: 50));
            AlterColumn("dbo.Candidates", "Website", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Candidates", "Website", c => c.String(maxLength: 10));
            AlterColumn("dbo.Candidates", "Country", c => c.String());
        }
    }
}

namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CandidateTablesAttributeChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Candidates", "Profession", c => c.String(maxLength: 100));
            AlterColumn("dbo.Candidates", "City", c => c.String(maxLength: 50));
            AlterColumn("dbo.Candidates", "Website", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Candidates", "Website", c => c.String(maxLength: 50));
            AlterColumn("dbo.Candidates", "City", c => c.String(maxLength: 20));
            AlterColumn("dbo.Candidates", "Profession", c => c.String(maxLength: 50));
        }
    }
}

namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CandidateEmployerProperitiesNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Candidates", "Firstname", c => c.String(maxLength: 50));
            AlterColumn("dbo.Candidates", "Lastname", c => c.String(maxLength: 50));
            AlterColumn("dbo.Candidates", "Email", c => c.String());
            AlterColumn("dbo.Employers", "Firstname", c => c.String(maxLength: 50));
            AlterColumn("dbo.Employers", "Lastname", c => c.String(maxLength: 50));
            AlterColumn("dbo.Employers", "Address", c => c.String(maxLength: 150));
            AlterColumn("dbo.Employers", "CompanyName", c => c.String(maxLength: 150));
            AlterColumn("dbo.Employers", "CompanyAdress", c => c.String(maxLength: 150));
            AlterColumn("dbo.Employers", "CompanyPhone", c => c.String(maxLength: 150));
            AlterColumn("dbo.Employers", "CompanyEmail", c => c.String());
            AlterColumn("dbo.Employers", "Followers", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employers", "Followers", c => c.Int(nullable: false));
            AlterColumn("dbo.Employers", "CompanyEmail", c => c.String(nullable: false));
            AlterColumn("dbo.Employers", "CompanyPhone", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Employers", "CompanyAdress", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Employers", "CompanyName", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Employers", "Address", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Employers", "Lastname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Employers", "Firstname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Candidates", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Candidates", "Lastname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Candidates", "Firstname", c => c.String(nullable: false, maxLength: 50));
        }
    }
}

namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyNameAddedJob : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "CompanyName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jobs", "CompanyName");
        }
    }
}

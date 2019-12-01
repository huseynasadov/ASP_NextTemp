namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserEmployerandUserCandidateCreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidates", "UserId", c => c.Int());
            AddColumn("dbo.Employers", "UserId", c => c.Int());
            CreateIndex("dbo.Candidates", "UserId");
            CreateIndex("dbo.Employers", "UserId");
            AddForeignKey("dbo.Candidates", "UserId", "dbo.Users", "Id");
            AddForeignKey("dbo.Employers", "UserId", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employers", "UserId", "dbo.Users");
            DropForeignKey("dbo.Candidates", "UserId", "dbo.Users");
            DropIndex("dbo.Employers", new[] { "UserId" });
            DropIndex("dbo.Candidates", new[] { "UserId" });
            DropColumn("dbo.Employers", "UserId");
            DropColumn("dbo.Candidates", "UserId");
        }
    }
}

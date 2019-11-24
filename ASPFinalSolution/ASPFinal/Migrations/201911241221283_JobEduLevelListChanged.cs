namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobEduLevelListChanged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Candidates", "JobEduLevel_Id", "dbo.JobEduLevels");
            DropIndex("dbo.Candidates", new[] { "JobEduLevel_Id" });
            DropColumn("dbo.Candidates", "JobEduLevel_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Candidates", "JobEduLevel_Id", c => c.Int());
            CreateIndex("dbo.Candidates", "JobEduLevel_Id");
            AddForeignKey("dbo.Candidates", "JobEduLevel_Id", "dbo.JobEduLevels", "Id");
        }
    }
}

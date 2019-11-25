namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OpeningHoursTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OpeningHours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Days = c.Int(nullable: false),
                        BeginHour = c.String(maxLength: 4),
                        EndHour = c.String(maxLength: 4),
                        JobId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .Index(t => t.JobId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OpeningHours", "JobId", "dbo.Jobs");
            DropIndex("dbo.OpeningHours", new[] { "JobId" });
            DropTable("dbo.OpeningHours");
        }
    }
}

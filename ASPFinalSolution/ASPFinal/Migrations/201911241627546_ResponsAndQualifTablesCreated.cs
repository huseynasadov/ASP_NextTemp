namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResponsAndQualifTablesCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Qualifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, maxLength: 300),
                        JobId = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .Index(t => t.JobId);
            
            CreateTable(
                "dbo.Responsibilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, maxLength: 300),
                        JobId = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .Index(t => t.JobId);
            
            AddColumn("dbo.Jobs", "Address", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Jobs", "WebSite", c => c.String(maxLength: 200));
            AlterColumn("dbo.Jobs", "Title", c => c.String(nullable: false, maxLength: 550));
            DropColumn("dbo.Jobs", "Country");
            DropColumn("dbo.Jobs", "City");
            DropColumn("dbo.Jobs", "Street");
            DropColumn("dbo.Jobs", "WebSiteLink");
            DropColumn("dbo.Jobs", "Qualification");
            DropColumn("dbo.Jobs", "Responsibilities");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Jobs", "Responsibilities", c => c.String(maxLength: 100));
            AddColumn("dbo.Jobs", "Qualification", c => c.String(maxLength: 100));
            AddColumn("dbo.Jobs", "WebSiteLink", c => c.String(maxLength: 200));
            AddColumn("dbo.Jobs", "Street", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Jobs", "City", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Jobs", "Country", c => c.String());
            DropForeignKey("dbo.Responsibilities", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.Qualifications", "JobId", "dbo.Jobs");
            DropIndex("dbo.Responsibilities", new[] { "JobId" });
            DropIndex("dbo.Qualifications", new[] { "JobId" });
            AlterColumn("dbo.Jobs", "Title", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.Jobs", "WebSite");
            DropColumn("dbo.Jobs", "Address");
            DropTable("dbo.Responsibilities");
            DropTable("dbo.Qualifications");
        }
    }
}

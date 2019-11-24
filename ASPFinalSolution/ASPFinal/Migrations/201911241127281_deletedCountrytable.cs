namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedCountrytable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Jobs", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Candidates", "CountryId", "dbo.Countries");
            DropIndex("dbo.Jobs", new[] { "CountryId" });
            DropIndex("dbo.Candidates", new[] { "CountryId" });
            AddColumn("dbo.Jobs", "Country", c => c.String());
            AddColumn("dbo.Candidates", "Country", c => c.String());
            DropColumn("dbo.Jobs", "CountryId");
            DropColumn("dbo.Candidates", "CountryId");
            DropTable("dbo.Countries");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Candidates", "CountryId", c => c.Int());
            AddColumn("dbo.Jobs", "CountryId", c => c.Int(nullable: false));
            DropColumn("dbo.Candidates", "Country");
            DropColumn("dbo.Jobs", "Country");
            CreateIndex("dbo.Candidates", "CountryId");
            CreateIndex("dbo.Jobs", "CountryId");
            AddForeignKey("dbo.Candidates", "CountryId", "dbo.Countries", "Id");
            AddForeignKey("dbo.Jobs", "CountryId", "dbo.Countries", "Id", cascadeDelete: true);
        }
    }
}

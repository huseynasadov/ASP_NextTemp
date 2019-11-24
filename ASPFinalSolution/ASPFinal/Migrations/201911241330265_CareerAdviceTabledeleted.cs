namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CareerAdviceTabledeleted : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.CareerAdvices");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CareerAdvices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Content = c.String(nullable: false, maxLength: 250),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        Photo = c.String(maxLength: 250),
                        OrderBy = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}

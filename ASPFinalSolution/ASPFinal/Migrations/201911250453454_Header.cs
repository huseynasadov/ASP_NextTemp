namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Header : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HeaderSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(maxLength: 250),
                        Page = c.Int(nullable: false),
                        HomeTitle = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HeaderSettings");
        }
    }
}

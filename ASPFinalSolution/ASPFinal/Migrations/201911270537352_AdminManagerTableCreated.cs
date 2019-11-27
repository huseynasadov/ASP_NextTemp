namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminManagerTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminManagers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 50),
                        Lastname = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Token = c.String(maxLength: 300),
                        Status = c.Boolean(nullable: false),
                        Photo = c.String(maxLength: 500),
                        AdminPosition = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AdminManagers");
        }
    }
}

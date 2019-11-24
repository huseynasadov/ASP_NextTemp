namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServiceContentLenghtChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Services", "Content", c => c.String(nullable: false, maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Services", "Content", c => c.String(nullable: false, maxLength: 100));
        }
    }
}

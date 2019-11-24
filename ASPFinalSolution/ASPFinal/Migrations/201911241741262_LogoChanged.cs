namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LogoChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "Logo", c => c.String(maxLength: 200));
            DropColumn("dbo.Settings", "LogoWhite");
            DropColumn("dbo.Settings", "LogoBlack");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Settings", "LogoBlack", c => c.String(maxLength: 200));
            AddColumn("dbo.Settings", "LogoWhite", c => c.String(maxLength: 200));
            DropColumn("dbo.Settings", "Logo");
        }
    }
}

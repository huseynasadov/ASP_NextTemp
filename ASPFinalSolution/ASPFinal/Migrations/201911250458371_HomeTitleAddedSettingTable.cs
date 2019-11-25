namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HomeTitleAddedSettingTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "HomeTitle", c => c.String(maxLength: 50));
            DropColumn("dbo.HeaderSettings", "HomeTitle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HeaderSettings", "HomeTitle", c => c.String(maxLength: 50));
            DropColumn("dbo.Settings", "HomeTitle");
        }
    }
}

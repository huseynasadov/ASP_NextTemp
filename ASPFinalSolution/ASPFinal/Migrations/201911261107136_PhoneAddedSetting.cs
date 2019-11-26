namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneAddedSetting : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "Phone", c => c.String(maxLength: 14));
            AddColumn("dbo.Settings", "Website", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Settings", "Website");
            DropColumn("dbo.Settings", "Phone");
        }
    }
}

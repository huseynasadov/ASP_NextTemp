namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserPosiyionChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserPosition", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserPosition", c => c.Int(nullable: false));
        }
    }
}

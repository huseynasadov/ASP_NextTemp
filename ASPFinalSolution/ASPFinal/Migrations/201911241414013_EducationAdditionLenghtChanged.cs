namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EducationAdditionLenghtChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Educations", "EduAddition", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Educations", "EduAddition", c => c.String(maxLength: 50));
        }
    }
}

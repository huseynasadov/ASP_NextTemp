namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EducationGraduatedDeleted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Educations", "Graduation");
            DropColumn("dbo.Educations", "Degree");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Educations", "Degree", c => c.String(maxLength: 50));
            AddColumn("dbo.Educations", "Graduation", c => c.String(maxLength: 50));
        }
    }
}

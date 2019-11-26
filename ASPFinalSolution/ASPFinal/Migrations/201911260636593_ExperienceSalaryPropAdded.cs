namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExperienceSalaryPropAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Experiences", "Salary", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Experiences", "Salary");
        }
    }
}

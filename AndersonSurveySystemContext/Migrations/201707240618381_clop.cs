namespace AndersonSurveySystemContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admin", "FirstName", c => c.String());
            AddColumn("dbo.Admin", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admin", "LastName");
            DropColumn("dbo.Admin", "FirstName");
        }
    }
}

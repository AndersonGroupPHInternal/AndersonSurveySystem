namespace AndersonSurveySystemContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dsad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AnsweredQuestion", "Comments", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AnsweredQuestion", "Comments");
        }
    }
}

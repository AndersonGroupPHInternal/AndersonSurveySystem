namespace AndersonSurveySystemContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcommentinAnsweredQuestion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AnsweredQuestion", "Comment", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AnsweredQuestion", "Comment");
        }
    }
}

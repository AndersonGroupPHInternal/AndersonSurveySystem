namespace AndersonSurveySystemContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comment", "Comments", c => c.String(maxLength: 250));
            DropColumn("dbo.AnsweredQuestion", "Comment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AnsweredQuestion", "Comment", c => c.String(maxLength: 250));
            AlterColumn("dbo.Comment", "Comments", c => c.String());
        }
    }
}

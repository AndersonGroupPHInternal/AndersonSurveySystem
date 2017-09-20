namespace AndersonSurveySystemContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asasasa : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Question", new[] { "EAnsweredQuestion_AnsweredQuestionid" });
            CreateIndex("dbo.Question", "EAnsweredQuestion_AnsweredQuestionId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Question", new[] { "EAnsweredQuestion_AnsweredQuestionId" });
            CreateIndex("dbo.Question", "EAnsweredQuestion_AnsweredQuestionid");
        }
    }
}

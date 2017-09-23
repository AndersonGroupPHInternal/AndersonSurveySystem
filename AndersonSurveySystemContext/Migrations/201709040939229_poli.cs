namespace AndersonSurveySystemContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class poli : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comment", "EAnsweredSurvey_AnsweredSurveyid", c => c.Int());
            CreateIndex("dbo.Comment", "EAnsweredSurvey_AnsweredSurveyid");
            AddForeignKey("dbo.Comment", "EAnsweredSurvey_AnsweredSurveyid", "dbo.AnsweredSurvey", "AnsweredSurveyid");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comment", "EAnsweredSurvey_AnsweredSurveyid", "dbo.AnsweredSurvey");
            DropIndex("dbo.Comment", new[] { "EAnsweredSurvey_AnsweredSurveyid" });
            DropColumn("dbo.Comment", "EAnsweredSurvey_AnsweredSurveyid");
        }
    }
}

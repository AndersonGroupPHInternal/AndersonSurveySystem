namespace AndersonSurveySystemContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 250),
                        LastName = c.String(maxLength: 250),
                        UserName = c.String(maxLength: 250),
                        Password = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.AnsweredSurvey",
                c => new
                    {
                        AnsweredSurveyid = c.Int(nullable: false, identity: true),
                        ReferenceNumber = c.String(),
                        Userid = c.Int(nullable: false),
                        EAdmin_AdminId = c.Int(),
                    })
                .PrimaryKey(t => t.AnsweredSurveyid)
                .ForeignKey("dbo.Admin", t => t.EAdmin_AdminId)
                .Index(t => t.EAdmin_AdminId);
            
            CreateTable(
                "dbo.AnsweredQuestion",
                c => new
                    {
                        AnsweredQuestionid = c.Int(nullable: false, identity: true),
                        Answer = c.String(maxLength: 50),
                        AnsweredSurvey_AnsweredSurveyid = c.Int(),
                        Questions_QuestionId = c.Int(),
                        Survey_SurveyId = c.Int(),
                    })
                .PrimaryKey(t => t.AnsweredQuestionid)
                .ForeignKey("dbo.AnsweredSurvey", t => t.AnsweredSurvey_AnsweredSurveyid)
                .ForeignKey("dbo.Question", t => t.Questions_QuestionId)
                .ForeignKey("dbo.Survey", t => t.Survey_SurveyId)
                .Index(t => t.AnsweredSurvey_AnsweredSurveyid)
                .Index(t => t.Questions_QuestionId)
                .Index(t => t.Survey_SurveyId);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                        Rate = c.Int(nullable: false),
                        EAnsweredQuestion_AnsweredQuestionid = c.Int(),
                        ETypeOfQuestion_TypeOfQuestionId = c.Int(),
                    })
                .PrimaryKey(t => t.QuestionId)
                .ForeignKey("dbo.AnsweredQuestion", t => t.EAnsweredQuestion_AnsweredQuestionid)
                .ForeignKey("dbo.TypeOfQuestion", t => t.ETypeOfQuestion_TypeOfQuestionId)
                .Index(t => t.EAnsweredQuestion_AnsweredQuestionid)
                .Index(t => t.ETypeOfQuestion_TypeOfQuestionId);
            
            CreateTable(
                "dbo.Survey",
                c => new
                    {
                        SurveyId = c.Int(nullable: false, identity: true),
                        SurveyName = c.String(maxLength: 250),
                        Rate = c.Int(nullable: false),
                        EComment_CommentId = c.Int(),
                        ERate_RateId = c.Int(),
                    })
                .PrimaryKey(t => t.SurveyId)
                .ForeignKey("dbo.Comment", t => t.EComment_CommentId)
                .ForeignKey("dbo.Rate", t => t.ERate_RateId)
                .Index(t => t.EComment_CommentId)
                .Index(t => t.ERate_RateId);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        SurveyId = c.Int(nullable: false),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.CommentId);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 250),
                        EmailAd = c.String(maxLength: 250),
                        ReferenceNumber = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Rate",
                c => new
                    {
                        RateId = c.Int(nullable: false, identity: true),
                        SurveyId = c.Int(nullable: false),
                        Rates = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RateId);
            
            CreateTable(
                "dbo.TypeOfQuestion",
                c => new
                    {
                        TypeOfQuestionId = c.Int(nullable: false, identity: true),
                        TypeOfQuestionName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.TypeOfQuestionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Question", "ETypeOfQuestion_TypeOfQuestionId", "dbo.TypeOfQuestion");
            DropForeignKey("dbo.Survey", "ERate_RateId", "dbo.Rate");
            DropForeignKey("dbo.Survey", "EComment_CommentId", "dbo.Comment");
            DropForeignKey("dbo.AnsweredSurvey", "EAdmin_AdminId", "dbo.Admin");
            DropForeignKey("dbo.AnsweredQuestion", "Survey_SurveyId", "dbo.Survey");
            DropForeignKey("dbo.AnsweredQuestion", "Questions_QuestionId", "dbo.Question");
            DropForeignKey("dbo.Question", "EAnsweredQuestion_AnsweredQuestionid", "dbo.AnsweredQuestion");
            DropForeignKey("dbo.AnsweredQuestion", "AnsweredSurvey_AnsweredSurveyid", "dbo.AnsweredSurvey");
            DropIndex("dbo.Survey", new[] { "ERate_RateId" });
            DropIndex("dbo.Survey", new[] { "EComment_CommentId" });
            DropIndex("dbo.Question", new[] { "ETypeOfQuestion_TypeOfQuestionId" });
            DropIndex("dbo.Question", new[] { "EAnsweredQuestion_AnsweredQuestionid" });
            DropIndex("dbo.AnsweredQuestion", new[] { "Survey_SurveyId" });
            DropIndex("dbo.AnsweredQuestion", new[] { "Questions_QuestionId" });
            DropIndex("dbo.AnsweredQuestion", new[] { "AnsweredSurvey_AnsweredSurveyid" });
            DropIndex("dbo.AnsweredSurvey", new[] { "EAdmin_AdminId" });
            DropTable("dbo.TypeOfQuestion");
            DropTable("dbo.Rate");
            DropTable("dbo.Emails");
            DropTable("dbo.Comment");
            DropTable("dbo.Survey");
            DropTable("dbo.Question");
            DropTable("dbo.AnsweredQuestion");
            DropTable("dbo.AnsweredSurvey");
            DropTable("dbo.Admin");
        }
    }
}

namespace AndersonSurveySystemContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initials : DbMigration
    {
        public override void Up()
        {
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
                "dbo.AnsweredSurvey",
                c => new
                    {
                        AnsweredSurveyid = c.Int(nullable: false, identity: true),
                        ReferenceNumber = c.String(),
                        Userid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AnsweredSurveyid);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
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
                    })
                .PrimaryKey(t => t.SurveyId);
            
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
            DropForeignKey("dbo.AnsweredQuestion", "Survey_SurveyId", "dbo.Survey");
            DropForeignKey("dbo.AnsweredQuestion", "Questions_QuestionId", "dbo.Question");
            DropForeignKey("dbo.Question", "EAnsweredQuestion_AnsweredQuestionid", "dbo.AnsweredQuestion");
            DropForeignKey("dbo.AnsweredQuestion", "AnsweredSurvey_AnsweredSurveyid", "dbo.AnsweredSurvey");
            DropIndex("dbo.Question", new[] { "ETypeOfQuestion_TypeOfQuestionId" });
            DropIndex("dbo.Question", new[] { "EAnsweredQuestion_AnsweredQuestionid" });
            DropIndex("dbo.AnsweredQuestion", new[] { "Survey_SurveyId" });
            DropIndex("dbo.AnsweredQuestion", new[] { "Questions_QuestionId" });
            DropIndex("dbo.AnsweredQuestion", new[] { "AnsweredSurvey_AnsweredSurveyid" });
            DropTable("dbo.TypeOfQuestion");
            DropTable("dbo.Survey");
            DropTable("dbo.Question");
            DropTable("dbo.AnsweredSurvey");
            DropTable("dbo.AnsweredQuestion");
        }
    }
}

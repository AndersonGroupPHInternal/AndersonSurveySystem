using AndersonSurveySystemEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace AndersonSurveySystemContext
{
    public class DBInitializer : CreateDatabaseIfNotExists<Context>
    {
        public DBInitializer()
        {

        }
        
        protected override void Seed(Context context)
        {
            ESurvey eSurvey = new ESurvey()
            {
                CreatedDate = DateTime.Now,

                CreatedBy = 0,

                SurveyName = "Default Survey"
            };
            eSurvey = context.Survey.Add(eSurvey);
            context.SaveChanges();
            if (eSurvey.SurveyId != 0)
            {
                List<EQuestion> eQuestions = new List<EQuestion>()
                {
                    new EQuestion
                    {
                        CreatedDate = DateTime.Now,

                        CreatedBy = 0,
                        SurveyId = eSurvey.SurveyId,

                        Description = "Was the Service Desk analyst helpful in diagnosing the cause of your problem/issue ?",
                        Name = "Diagnostic"
                    },
                    new EQuestion
                    {
                        CreatedDate = DateTime.Now,

                        CreatedBy = 0,
                        SurveyId = eSurvey.SurveyId,

                        Description = "Was the Service Desk analyst able to resolve your problem/issue (N/A if call was transferred, escalated to Tier 2) ?",
                        Name= "Resolution"
                    },
                    new EQuestion
                    {
                        CreatedDate = DateTime.Now,

                        CreatedBy = 0,
                        SurveyId = eSurvey.SurveyId,

                        Description = "How satisfied were you with the delivery of the resolution of your problem/issue ?",
                        Name="Satisfaction"
                    },
                    new EQuestion
                    {
                        CreatedDate = DateTime.Now,

                        CreatedBy = 0,
                        SurveyId = eSurvey.SurveyId,

                        Description = "Was the Service Desk analyst courteous, friendly and accommodating ?",
                        Name="Courtiousness"
                    },
                    new EQuestion
                    {
                        CreatedDate = DateTime.Now,

                        CreatedBy = 0,
                        SurveyId = eSurvey.SurveyId,

                        Description = "How would you rate your overall level of satisfaction with the Service Desk team ?",
                        Name="Overall"
                    },
                };
                context.Question.AddRange(eQuestions);
                context.SaveChanges();
            }
        }
    }
}

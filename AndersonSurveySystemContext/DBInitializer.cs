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

            if (eSurvey.SurveyId != 0)
            {
                List<EQuestion> eQuestions = new List<EQuestion>()
                {
                    new EQuestion
                    {
                        CreatedDate = DateTime.Now,

                        CreatedBy = 0,
                        SurveyId = eSurvey.SurveyId,

                        Description = "Was the SD analyst helpful in diagnosing the cause of your problem/issue ?",
                    },
                    new EQuestion
                    {
                        CreatedDate = DateTime.Now,

                        CreatedBy = 0,
                        SurveyId = eSurvey.SurveyId,

                        Description = "Was the SD analyst able to resolve your problem/issue (N/A if call was transferred, escalated to T2) ?",
                    },
                    new EQuestion
                    {
                        CreatedDate = DateTime.Now,

                        CreatedBy = 0,
                        SurveyId = eSurvey.SurveyId,

                        Description = "How satisfied were you with the delivery of the resolution of your problem/issue ?",
                    },
                    new EQuestion
                    {
                        CreatedDate = DateTime.Now,

                        CreatedBy = 0,
                        SurveyId = eSurvey.SurveyId,

                        Description = "Was the SD analyst courteous, friendly and accommodating ?",
                    },
                    new EQuestion
                    {
                        CreatedDate = DateTime.Now,

                        CreatedBy = 0,
                        SurveyId = eSurvey.SurveyId,

                        Description = "How would you rate your overall level of satisfaction with other service desk team ?",
                    },
                };
            }
        }
    }
}

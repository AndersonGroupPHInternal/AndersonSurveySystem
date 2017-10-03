using AndersonSurveySystemContext;
using AndersonSurveySystemEntity;
using BaseData;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace AndersonSurveySystemData
{
    public class DAnsweredQuestion : DBase, IDAnsweredQuestion
    {
        public DAnsweredQuestion() : base (new Context())
        {
        }

        #region Read
        public List<EAnsweredQuestion> Read(int answeredSurveyId)
        {
            using (var context = new Context())
            {
                return context.AnsweredQuestion
                    .Include(a => a.Question)
                    .Where(a => a.AnsweredSurveyId == answeredSurveyId)
                    .OrderBy(a => a.AnsweredQuestionId)
                    .ToList();
            }
        }
        #endregion
    }
}

using AndersonSurveySystemContext;
using AndersonSurveySystemEntity;
using BaseData;
using System.Data.Entity;
using System.Linq;

namespace AndersonSurveySystemData
{
    public class DSurvey : DBase, IDSurvey
    {
        public DSurvey() : base(new Context())
        {
        }

        public ESurvey Read(int surveyId)
        {
            using (var context = new Context())
            {
                return context.Survey
                    .Include(a => a.Questions)
                    .FirstOrDefault(a => a.SurveyId == surveyId);
            }
        }
    }
}

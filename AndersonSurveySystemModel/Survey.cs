using System.Collections.Generic;

namespace AndersonSurveySystemModel
{
    public class Survey : Base.Base
    {
        public int SurveyId { get; set; }

        public string SurveyName { get; set; }

        public IEnumerable<AnsweredSurvey> AnsweredSurveys { get; set; }
        public IEnumerable<Question> Questions { get; set; }
       
    }
}

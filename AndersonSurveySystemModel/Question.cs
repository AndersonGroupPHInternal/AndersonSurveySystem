using System.Collections.Generic;

namespace AndersonSurveySystemModel
{
    public class Question : Base.Base
    {
        public int QuestionId { get; set; }
        public int SurveyId { get; set; }

        public string Description { get; set; }
        public string Name { get; set; }

        public List<AnsweredQuestion> AnsweredQuestion { get; set; }
    }
}

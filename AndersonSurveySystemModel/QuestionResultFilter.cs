using System;

namespace AndersonSurveySystemModel
{
    public class QuestionResultFilter
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public int SurveyId { get; set; }
    }
}

using System.Collections.Generic;


namespace AndersonSurveySystemModel
{
    public class AnsweredSurvey
    {
        public int AnsweredSurveyId { get; set; }
        public int SurveyId { get; set; }

        public string Description { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string TicketNumber { get; set; }

        public Survey Survey { get; set; }

        public IEnumerable<AnsweredQuestion> AnsweredQuestions { get; set; }
    }
}

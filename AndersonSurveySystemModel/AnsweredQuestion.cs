namespace AndersonSurveySystemModel
{
    public class AnsweredQuestion
    {
        public int Answer { get; set; }
        public int AnsweredQuestionId { get; set; }
        public int AnsweredSurveyId { get; set; }
        public int QuestionId { get; set; }

        public AnsweredSurvey AnsweredSurvey { get; set; }
        public Question Question { get; set; }
    }
}

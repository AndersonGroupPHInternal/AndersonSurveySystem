using AndersonSurveySystemModel;
using AndersonSurveySystemData;
using AndersonSurveySystemEntity;
using System.Collections.Generic;
using System.Linq;

namespace AndersonSurveySystemFunction
{
    public class FQuestion : IFQuestion
    {
        private IDQuestion _iDQuestion;

        public FQuestion()
        {
            _iDQuestion = new DQuestion();
        }

        #region CREATE
        public Question Create(Question question)
        {
            EQuestion eQuestion = EQuestion(question);
            eQuestion = _iDQuestion.Create(eQuestion);
            return (Question(eQuestion));
        }
        #endregion

        #region READ
        public Question Read(int questionId)
        {
            EQuestion eQuestion = _iDQuestion.Read<EQuestion>(a => a.QuestionId == questionId);
            return Question(eQuestion);
        }

        public List<Question> List()
        {
            List<EQuestion> eQuestions = _iDQuestion.List<EQuestion>(a => true);
            return Questions(eQuestions);
        }
        #endregion

        #region UPDATE
        public Question Update(Question question)
        {
            var eQuestion = _iDQuestion.Update(EQuestion(question));
            return (Question(eQuestion));
        }
        #endregion

        #region DELETE
        public void Delete(Question question)
        {
            _iDQuestion.Delete(EQuestion(question));
        }
        #endregion


        private List<Question> Questions(List<EQuestion> eQuestions)
        {
            var returnQuestions = eQuestions.Select(a => new Question
            {
                QuestionId = a.QuestionId,
                Description = a.Description,
                Rate = a.Rate,
            });

            return returnQuestions.ToList();
        }

        private EQuestion EQuestion(Question question)
        {
            EQuestion returnEQuestion = new EQuestion
            {
                QuestionId = question.QuestionId,
                Description = question.Description,
                Rate = question.Rate,

            };
            return returnEQuestion;
        }

        private Question Question(EQuestion eQuestion)
        {
            Question returnQuestion = new Question
            {
                QuestionId = eQuestion.QuestionId,
                Description = eQuestion.Description,
                Rate = eQuestion.Rate,
            };
            return returnQuestion;
        }
    }
}
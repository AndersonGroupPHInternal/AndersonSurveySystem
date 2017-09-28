using AndersonSurveySystemModel;
using AndersonSurveySystemData;
using AndersonSurveySystemEntity;
using System.Collections.Generic;
using System.Linq;

namespace AndersonSurveySystemFunction
{
    public class FAnsweredQuestion : IFAnsweredQuestion
    {
        private IDAnsweredQuestion _iDAnsweredQuestion;

        public FAnsweredQuestion()
        {
            _iDAnsweredQuestion = new DAnsweredQuestion();
        }

        #region CREATE
        public AnsweredQuestion Create(AnsweredQuestion answeredquestion)
        {
            EAnsweredQuestion eAnsweredQuestion = EAnsweredQuestion(answeredquestion);
            eAnsweredQuestion = _iDAnsweredQuestion.Create(eAnsweredQuestion);
            return (AnsweredQuestion(eAnsweredQuestion));
        }
        #endregion

        #region READ
        public AnsweredQuestion Read(int answeredquestionId)
        {
            EAnsweredQuestion eAnsweredQuestion = _iDAnsweredQuestion.Read<EAnsweredQuestion>(a => a.AnsweredQuestionId == answeredquestionId);
            return AnsweredQuestion(eAnsweredQuestion);
        }

        public List<AnsweredQuestion> List()
        {
            List<EAnsweredQuestion> eAnsweredQuestions = _iDAnsweredQuestion.List<EAnsweredQuestion>(a => true);
            return AnsweredQuestions(eAnsweredQuestions);
        }

        #endregion

        #region UPDATE
        public AnsweredQuestion Update(AnsweredQuestion answeredquestion)
        {
            var eAnsweredQuestion = _iDAnsweredQuestion.Update(EAnsweredQuestion(answeredquestion));
            return (AnsweredQuestion(eAnsweredQuestion));
        }
        #endregion

        #region DELETE
        public void Delete(AnsweredQuestion answeredquestion)
        {
            _iDAnsweredQuestion.Delete(EAnsweredQuestion(answeredquestion));
        }
        #endregion
        #region OTHER FUNCTION
        private List<AnsweredQuestion> AnsweredQuestions(List<EAnsweredQuestion> eAnsweredQuestions)
        {
            var returnAnsweredQuestions = eAnsweredQuestions.Select(a => new AnsweredQuestion
            {
                AnsweredQuestionId = a.AnsweredQuestionId,
                Answer = a.Answer,
                QuestionId = a.QuestionId
            });

            return returnAnsweredQuestions.ToList();
        }

        private EAnsweredQuestion EAnsweredQuestion(AnsweredQuestion answeredquestion)
        {
            EAnsweredQuestion returnEAnsweredQuestion = new EAnsweredQuestion
            {
                AnsweredQuestionId = answeredquestion.AnsweredQuestionId,
                Answer = answeredquestion.Answer,
                QuestionId = answeredquestion.QuestionId
                
        };

            return returnEAnsweredQuestion;
        }

        private AnsweredQuestion AnsweredQuestion(EAnsweredQuestion eAnsweredQuestion)
        {
            AnsweredQuestion returnAnsweredQuestion = new AnsweredQuestion
            {
                AnsweredQuestionId = eAnsweredQuestion.AnsweredQuestionId,
                Answer = eAnsweredQuestion.Answer,
                QuestionId = eAnsweredQuestion.QuestionId
            };
            return returnAnsweredQuestion;
        }
        #endregion
    }
}

using AndersonSurveySystemModel;
using AndersonSurveySystemData;
using AndersonSurveySystemEntity;
using System.Collections.Generic;
using System.Linq;
using System;

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
        public AnsweredQuestion Create(AnsweredQuestion answeredQuestion)
        {
            EAnsweredQuestion eAnsweredQuestion = EAnsweredQuestion(answeredQuestion);
            eAnsweredQuestion.CreatedDate = DateTime.Now;
            eAnsweredQuestion = _iDAnsweredQuestion.Create(eAnsweredQuestion);
            return (AnsweredQuestion(eAnsweredQuestion));
        }
        #endregion

        #region READ
        public List<AnsweredQuestion> Read(int answeredSurveyId)
        {
            List<EAnsweredQuestion> eAnsweredQuestions = _iDAnsweredQuestion.Read(answeredSurveyId);
            return AnsweredQuestions(eAnsweredQuestions);
        }
        #endregion

        #region UPDATE
        #endregion

        #region DELETE
        #endregion

        #region OTHER
        private AnsweredQuestion AnsweredQuestion(EAnsweredQuestion eAnsweredQuestion)
        {
            return new AnsweredQuestion
            {
                Answer = eAnsweredQuestion.Answer,
                AnsweredQuestionId = eAnsweredQuestion.AnsweredQuestionId,
                AnsweredSurveyId = eAnsweredQuestion.AnsweredSurveyId,
                QuestionId = eAnsweredQuestion.QuestionId
            };
        }

        private EAnsweredQuestion EAnsweredQuestion(AnsweredQuestion answeredQuestion)
        {
            return new EAnsweredQuestion
            {
                Answer = answeredQuestion.Answer,
                AnsweredQuestionId = answeredQuestion.AnsweredQuestionId,
                AnsweredSurveyId = answeredQuestion.AnsweredSurveyId,
                QuestionId = answeredQuestion.QuestionId
            };
        }

        private List<AnsweredQuestion> AnsweredQuestions(List<EAnsweredQuestion> eAnsweredQuestions)
        {
            return eAnsweredQuestions.Select(a => new AnsweredQuestion
            {
                Answer = a.Answer,
                AnsweredQuestionId = a.AnsweredQuestionId,
                AnsweredSurveyId = a.AnsweredSurveyId,
                QuestionId = a.QuestionId,

                Question = new Question
                {
                    QuestionId = a.Question.QuestionId,
                    SurveyId = a.Question.SurveyId,

                    Description = a.Question.Description
                }
            }).ToList();            
        }
        #endregion
    }
}

using AndersonSurveySystemModel;
using AndersonSurveySystemData;
using AndersonSurveySystemEntity;
using System.Collections.Generic;
using System.Linq;
using System;

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
        public Question Create(int createdBy, Question question)
        {
            var eQuestion = EQuestion(question);
            eQuestion.CreatedDate = DateTime.Now;
            eQuestion.CreatedBy = createdBy;
            eQuestion = _iDQuestion.Create(eQuestion);
            return Question(eQuestion);
        }
        #endregion

        #region READ
        public Question Read(int questionId)
        {
            EQuestion eQuestion = _iDQuestion.Read<EQuestion>(a => a.QuestionId == questionId);
            return Question(eQuestion);
        }

        public List<Question> Read(int surveyId, string sortBy)
        {
            List<EQuestion> eQuestions = _iDQuestion.Read<EQuestion>(a => a.SurveyId == surveyId, sortBy);
            return Questions(eQuestions);
        }

        public List<Question> Read()
        {
            List<EQuestion> eQuestions = _iDQuestion.List<EQuestion>(a => true);
            return Questions(eQuestions);
        }
        #endregion

        #region UPDATE
        public Question Update(int updatedBy, Question question)
        {
            var eQuestion = _iDQuestion.Update(EQuestion(question));
            eQuestion.UpdatedDate = DateTime.Now;
            eQuestion.UpdatedBy = updatedBy;
            eQuestion = _iDQuestion.Update(eQuestion);
            return Question(eQuestion);
        }
        #endregion

        #region DELETE
        public void Delete(int questionId)
        {
            _iDQuestion.Delete<EQuestion>(a => a.QuestionId == questionId);
        }
        #endregion

        #region  OTHER
        private EQuestion EQuestion(Question question)
        {
            return new EQuestion
            {
                QuestionId = question.QuestionId,
                SurveyId = question.SurveyId,

                Description = question.Description
            };
        }

        private Question Question(EQuestion eQuestion)
        {
            return new Question
            {
                QuestionId = eQuestion.QuestionId,
                SurveyId = eQuestion.SurveyId,

                Description = eQuestion.Description
            };
        }

        private List<Question> Questions(List<EQuestion> eQuestions)
        {
            return eQuestions.Select(a => new Question
            {
                QuestionId = a.QuestionId,
                SurveyId = a.SurveyId,

                Description = a.Description
            }).ToList();
        }
        #endregion
    }
}
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
        public void Create(int surveyId, int createdBy, List<Question> questions)
        {
            if (!questions?.Any() ?? true)
                return;

            List<EQuestion> eQuestion = EQuestion(questions);
            List<EQuestion> newEQuestion = eQuestion.Where(a => a.QuestionId == 0).ToList();
            newEQuestion.ToList().ForEach(a =>
            {
                a.CreatedDate = DateTime.Now;

                a.SurveyId = surveyId;
                a.CreatedBy = createdBy;
            });
            _iDQuestion.Create(newEQuestion);
        }
        #endregion

        #region READ
        public List<Question> Read(int surveyId)
        {
            List<EQuestion> eQuestions = _iDQuestion.List<EQuestion>(a => a.SurveyId == surveyId);
            return Questions(eQuestions);
        }
        #endregion

        #region UPDATE
        #endregion

        #region DELETE
        public void Delete(List<Question> questions)
        {
            if (!questions?.Any() ?? true)
                return;

            List<EQuestion> eQuestions = EQuestion(questions);
            List<int> oldEQuestionIds = eQuestions.Where(a => a.QuestionId != 0).Select(a => a.QuestionId).ToList();
            _iDQuestion.Delete<EQuestion>(a => oldEQuestionIds.Contains(a.QuestionId));
        }
        #endregion

        #region  OTHER
        private List<EQuestion> EQuestion(List<Question> question)
        {
            return question.Select(a => new EQuestion
            {
                QuestionId = a.QuestionId,
                SurveyId = a.SurveyId,

                Description = a.Description
            }).ToList();
        }
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
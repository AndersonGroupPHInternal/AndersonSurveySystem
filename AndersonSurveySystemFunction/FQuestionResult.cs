using AndersonSurveySystemModel;
using AndersonSurveySystemData;
using AndersonSurveySystemEntity;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AndersonSurveySystemFunction
{
    public class FQuestionResult : IFQuestionResult
    {
        private IDQuestionResult _iDQuestionResult;

        public FQuestionResult()
        {
            _iDQuestionResult = new DQuestionResult();
        }

        #region CREATE
        #endregion

        #region READ
        public List<QuestionResult> Read(int surveyId)
        {
            List<QuestionResult> questionResults = new List<QuestionResult>();
            var questions = _iDQuestionResult.Read<EQuestion>(a => a.SurveyId == surveyId, "QuestionId");
            foreach (var question in questions)
            {
                var answeredQuestions = _iDQuestionResult.Read<EAnsweredQuestion>(a => a.QuestionId == question.QuestionId, "QuestionId");
                var rate = answeredQuestions.Average(a => a.Answer);

                questionResults.Add(new QuestionResult
                {
                    Description = question.Description,
                    Rate = rate
                });
            }
            return questionResults;
        }

        public List<QuestionResult> Read(QuestionResultFilter questionResultFilter)
        {
            List<QuestionResult> questionResults = new List<QuestionResult>();
            var questions = _iDQuestionResult.Read<EQuestion>(a => a.SurveyId == questionResultFilter.SurveyId, "QuestionId");
            var questionNumber = 0;
            foreach (var question in questions)
            {
                questionNumber++;

                var answeredQuestions = _iDQuestionResult.Read<EAnsweredQuestion>(a => a.QuestionId == question.QuestionId && a.CreatedDate >= questionResultFilter.From && a.CreatedDate <= questionResultFilter.To, "QuestionId");
                double rate = 0;

                if (answeredQuestions.Any())
                    rate = answeredQuestions.Average(a => a.Answer);

                questionResults.Add(new QuestionResult
                {
                    Number = questionNumber,
                    Description = question.Description,
                    Name = question.Name,
                    Rate = rate
                });
            }
            return questionResults;
        }
        #endregion

        #region UPDATE
        #endregion

        #region DELETE
        #endregion

        #region  OTHER
        #endregion
    }
}
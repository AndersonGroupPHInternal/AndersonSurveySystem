using AndersonSurveySystemModel;
using AndersonSurveySystemData;
using AndersonSurveySystemEntity;
using System.Collections.Generic;
using System.Linq;

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
        #endregion

        #region UPDATE
        #endregion

        #region DELETE
        #endregion

        #region  OTHER
        #endregion
    }
}
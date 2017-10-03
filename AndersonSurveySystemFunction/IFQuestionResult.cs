using AndersonSurveySystemModel;
using System.Collections.Generic;


namespace AndersonSurveySystemFunction
{
    public interface IFQuestionResult
    {
        #region CREATE
        #endregion

        #region READ
        List<QuestionResult> Read(int surveyId);
        #endregion

        #region UPDATE
        #endregion

        #region DELETE
        #endregion
    }
}

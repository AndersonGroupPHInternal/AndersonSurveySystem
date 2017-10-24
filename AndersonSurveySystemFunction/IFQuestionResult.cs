using AndersonSurveySystemModel;
using System;
using System.Collections.Generic;


namespace AndersonSurveySystemFunction
{
    public interface IFQuestionResult
    {
        #region CREATE
        #endregion

        #region READ
        List<QuestionResult> Read(int surveyId);
        List<QuestionResult> Read(QuestionResultFilter questionResultFilter);
        #endregion

        #region UPDATE
        #endregion

        #region DELETE
        #endregion
    }
}

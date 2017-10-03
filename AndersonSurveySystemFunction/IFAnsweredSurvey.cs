using AndersonSurveySystemModel;
using System.Collections.Generic;

namespace AndersonSurveySystemFunction
{
    public interface IFAnsweredSurvey
    {
        #region CREATE
        AnsweredSurvey Create(AnsweredSurvey answeredSurvey);
        #endregion

        #region RETRIEVE
        AnsweredSurvey Read(int answeredSurveyId);
        List<AnsweredSurvey> List();
        #endregion

        #region UPDATE
        #endregion

        #region DELETE
        void Delete(AnsweredSurvey answeredsurvey);
        #endregion
    }
}

using AndersonSurveySystemModel;
using System.Collections.Generic;

namespace AndersonSurveySystemFunction
{
    public interface IFAnsweredSurvey
    {
        #region CREATE
        AnsweredSurvey Create(AnsweredSurvey answeredsurvey);
        #endregion
        #region RETRIEVE
        AnsweredSurvey Read(int answeredsurveyId);
        List<AnsweredSurvey> List();
        #endregion
        #region UPDATE
        AnsweredSurvey Update(AnsweredSurvey answeredsurvey);
        #endregion
        #region DELETE
        void Delete(AnsweredSurvey answeredsurvey);
        #endregion

        #region CreateList
        AnsweredSurvey CreateList(AnsweredSurvey answeredsurvey);
        #endregion
    }
}

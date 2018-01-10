using AndersonSurveySystemModel;
using System.Collections.Generic;

namespace AndersonSurveySystemFunction
{
    public interface IFSurvey
    {
        #region CREATE
        Survey Create(int createdBy, Survey survey);
        #endregion

        #region READ
        Survey Read(int surveyId);
        List<Survey> Read();
        List<Survey> List();
        #endregion

        #region UPDATE
        Survey Update(int updatedBy, Survey survey);
        #endregion

        #region DELETE
        void Delete(int SurveyId);
        #endregion
    }
}

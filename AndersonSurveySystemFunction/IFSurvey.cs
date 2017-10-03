using AndersonSurveySystemModel;
using System.Collections.Generic;

namespace AndersonSurveySystemFunction
{
    public interface IFSurvey
    {
        #region CREATE
        Survey Create(int createdBy, Survey survey);
        #endregion

        #region RETRIEVE
        Survey Read(int surveyId);
        List<Survey> List();
        #endregion

        #region UPDATE
        Survey Update(int updatedBy, Survey survey);
        #endregion

        #region DELETE
        void Delete(Survey survey);
        #endregion
    }
}

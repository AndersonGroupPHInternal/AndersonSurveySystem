using AndersonSurveySystemModel;
using System.Collections.Generic;


namespace AndersonSurveySystemFunction
{
    public interface IFQuestion
    {
        #region CREATE
        Question Create(int createdBy, Question question);
        #endregion

        #region READ
        Question Read(int questionId);
        List<Question> Read(int surveyId, string sortBy);
        List<Question> List();
        #endregion

        #region UPDATE
        Question Update(int updatedBy, Question question);
        #endregion

        #region DELETE
        void Delete(Question question);
        #endregion
    }
}

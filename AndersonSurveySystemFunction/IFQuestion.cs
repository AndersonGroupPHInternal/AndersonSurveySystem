using AndersonSurveySystemModel;
using System.Collections.Generic;

namespace AndersonSurveySystemFunction
{
    public interface IFQuestion
    {
        #region Create
       Question Create(int createdBy, Question question);
        #endregion

        #region Read
        Question Read(int questionId);
        List<Question> Read(int surveyId, string sortBy);
        List<Question> Read();
        #endregion

        #region Update
       Question Update(int updatedBy, Question question);
        #endregion

        #region Delete
        void Delete(int questionId);
        #endregion

        #region Other Function

        #endregion
    }
}
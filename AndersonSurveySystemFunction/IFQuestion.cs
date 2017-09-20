using AndersonSurveySystemModel;
using System.Collections.Generic;


namespace AndersonSurveySystemFunction
{
    public interface IFQuestion
    {
        #region CREATE
        Question Create(Question question);
        #endregion

        #region READ
        Question Read(int questionId);
        List<Question> List();
        #endregion

        #region UPDATE
        Question Update(Question question);
        #endregion

        #region DELETE
        void Delete(Question question);
        #endregion
    }
}

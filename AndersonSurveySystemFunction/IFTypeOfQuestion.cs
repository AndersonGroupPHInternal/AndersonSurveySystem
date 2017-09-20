using AndersonSurveySystemModel;
using System.Collections.Generic;


namespace AndersonSurveySystemFunction
{
    public interface IFTypeOfQuestion
    {
        #region CREATE
        TypeOfQuestion Create(TypeOfQuestion typeofquestion);
        #endregion
        #region RETRIEVE
        TypeOfQuestion Read(int typeofquestionId);
        List<TypeOfQuestion> List();
        #endregion
        #region UPDATE
        TypeOfQuestion Update(TypeOfQuestion typeofquestion);
        #endregion
        #region DELETE
        void Delete(TypeOfQuestion typeofquestion);
        #endregion
    }
}

using AndersonSurveySystemModel;
using System.Collections.Generic;

namespace AndersonSurveySystemFunction
{
    public interface IFEmail
    {
        #region CREATE
        Email Create(Email email);
        #endregion
        #region RETRIEVE
        Email Read(int UserId);
        List<Email> List();
        #endregion
        #region UPDATE
        Email Update(Email email);
        bool IsMethodAccessible(string username, List<string> list);
        #endregion
        #region DELETE
        void Delete(Email email);
        object ReadUser(string username);
        #endregion
    }
}

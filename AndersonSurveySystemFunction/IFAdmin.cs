using AndersonSurveySystemModel;
using System.Collections.Generic;

namespace AndersonSurveySystemFunction
{
    public interface IFAdmin
    {
        #region CREATE
        Admin Create(Admin admin);
        #endregion
        #region RETRIEVE
        Admin Read(int adminId);
        List<Admin> List();
        #endregion
        #region UPDATE
        Admin Update(Admin admin);
        bool IsMethodAccessible(string username, List<string> list);
        #endregion
        #region DELETE
        void Delete(Admin admin);
        object ReadUser(string username);
        #endregion
    }
}

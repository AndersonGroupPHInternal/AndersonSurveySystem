using AndersonSurveySystemModel;
using System.Collections.Generic;

namespace AndersonSurveySystemFunction
{
    public interface IFRate
    {
        #region CREATE
        Rate Create(Rate rate);
        #endregion
        #region RETRIEVE
        Rate Read(int RateId);
        List<Rate> List();
        #endregion
        #region UPDATE
        Rate Update(Rate rate);
        bool IsMethodAccessible(string username, List<string> list);
        #endregion
        #region DELETE
        void Delete(Rate rate);
        object ReadUser(string username);
        #endregion
    }
}

using AndersonSurveySystemModel;
using System.Collections.Generic;

namespace AndersonSurveySystemFunction
{
    public interface IFComment
    {
        #region CREATE
        Comment Create(Comment comment);
        #endregion
        #region RETRIEVE
        Comment Read(int CommentId);
        List<Comment> List();
        #endregion
        #region UPDATE
        Comment Update(Comment comment);
        bool IsMethodAccessible(string username, List<string> list);
        #endregion
        #region DELETE
        void Delete(Comment comment);
        object ReadUser(string username);
        #endregion
    }
}

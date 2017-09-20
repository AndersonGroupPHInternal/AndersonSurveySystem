using AndersonSurveySystemModel;
using System.Collections.Generic;

namespace AndersonSurveySystemFunction
{
    public interface IFAnsweredQuestion
    {
        #region CREATE
        AnsweredQuestion Create(AnsweredQuestion answeredquestion);
        #endregion
        #region RETRIEVE
        AnsweredQuestion Read(int answeredquestionId);
        List<AnsweredQuestion> List();
        #endregion
        #region UPDATE
        AnsweredQuestion Update(AnsweredQuestion answeredquestion);
        #endregion
        #region DELETE
        void Delete(AnsweredQuestion answeredquestion);
        #endregion
    }
}

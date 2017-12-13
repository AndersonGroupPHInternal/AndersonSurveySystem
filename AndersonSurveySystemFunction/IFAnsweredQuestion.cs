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
        List<AnsweredQuestion> Read(int answeredSurveyId);
        List<AnsweredQuestion> Read(QuestionResultFilter questionResultFilter);
        #endregion

        #region UPDATE
        #endregion

        #region DELETE
        #endregion
    }
}

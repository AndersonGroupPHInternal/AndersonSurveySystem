using AndersonSurveySystemEntity;
using BaseData;
using System.Collections.Generic;

namespace AndersonSurveySystemData
{
    public interface IDAnsweredQuestion : IDBase
    {
        #region Read
        List<EAnsweredQuestion> Read(int answeredSurveyId);
        #endregion

    }
}

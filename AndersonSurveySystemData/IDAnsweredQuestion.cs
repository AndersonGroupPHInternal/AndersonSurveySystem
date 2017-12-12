using AndersonSurveySystemEntity;
using BaseData;
using System;
using System.Collections.Generic;

namespace AndersonSurveySystemData
{
    public interface IDAnsweredQuestion : IDBase
    {
        #region Read
        List<EAnsweredQuestion> Read(int answeredSurveyId);
        List<EAnsweredQuestion> Read(Func<EAnsweredQuestion, bool> filter);
        #endregion

    }
}

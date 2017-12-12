using AndersonSurveySystemEntity;
using BaseData;
using System.Collections.Generic;

namespace AndersonSurveySystemData
{
    public interface IDQuestion : IDBase
    {
        #region Read
        List<EQuestion> Read();
        #endregion
    }
}

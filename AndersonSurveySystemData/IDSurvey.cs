using AndersonSurveySystemEntity;
using BaseData;

namespace AndersonSurveySystemData
{
    public interface IDSurvey : IDBase
    {
        ESurvey Read(int surveyId);
    }
}

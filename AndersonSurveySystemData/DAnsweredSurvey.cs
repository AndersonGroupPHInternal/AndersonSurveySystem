using AndersonSurveySystemContext;
using BaseData;

namespace AndersonSurveySystemData
{
    public class DAnsweredSurvey : DBase, IDAnsweredSurvey
    {
        public DAnsweredSurvey() : base (new Context()){

        }
    }
}

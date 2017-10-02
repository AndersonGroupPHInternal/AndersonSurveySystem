using AndersonSurveySystemContext;
using BaseData;

namespace AndersonSurveySystemData
{
    public class DAnsweredQuestion : DBase, IDAnsweredQuestion
    {
        public DAnsweredQuestion() : base (new Context())
        {
        }
    }
}

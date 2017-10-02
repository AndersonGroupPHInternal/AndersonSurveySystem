using AndersonSurveySystemContext;
using BaseData;

namespace AndersonSurveySystemData
{
    public class DQuestion : DBase, IDQuestion
    {
        public DQuestion() : base (new Context())
        {
        }
    }
}

using AndersonSurveySystemContext;
using BaseData;

namespace AndersonSurveySystemData
{
    public class DTypeOfQuestion : DBase, IDTypeOfQuestion
    {
        public DTypeOfQuestion() : base(new Context())
        {
        }
    }
}

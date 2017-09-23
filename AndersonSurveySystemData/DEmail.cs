using AndersonSurveySystemContext;
using BaseData;

namespace AndersonSurveySystemData
{
    public class DEmail : DBase, IDEmail
    {
        public DEmail() : base(new Context())
        {
        }
    }
}

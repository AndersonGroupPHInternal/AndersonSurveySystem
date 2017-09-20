using AndersonSurveySystemContext;
using BaseData;

namespace AndersonSurveySystemData
{
    public class DAdmin : DBase, IDAdmin
    {
        public DAdmin() : base(new Context())
        {
        }
    }
}

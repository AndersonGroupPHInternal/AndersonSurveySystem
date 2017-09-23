using AndersonSurveySystemContext;
using BaseData;

namespace AndersonSurveySystemData
{
    public class DComment : DBase, IDComment
    {
        public DComment() : base(new Context())
        {
        }
    }
}

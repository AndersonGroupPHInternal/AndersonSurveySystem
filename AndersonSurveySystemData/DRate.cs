using AndersonSurveySystemContext;
using BaseData;
using AndersonSurveySystemModel;

namespace AndersonSurveySystemData
{
    public class DRate : DBase, IDRate
    {
        public DRate() : base(new Context())
        {
            

        }
    }
}

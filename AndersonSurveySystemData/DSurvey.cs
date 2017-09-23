using AndersonSurveySystemContext;
using BaseData;
namespace AndersonSurveySystemData
{
    public class DSurvey : DBase, IDSurvey
    {
        public DSurvey() : base(new Context())
        {
        }
    }
}

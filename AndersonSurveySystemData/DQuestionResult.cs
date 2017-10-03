using AndersonSurveySystemContext;
using BaseData;

namespace AndersonSurveySystemData
{
    public class DQuestionResult : DBase, IDQuestionResult
    {
        public DQuestionResult() : base (new Context())
        {
        }
    }
}

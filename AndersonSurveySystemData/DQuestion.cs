using AndersonSurveySystemContext;
using AndersonSurveySystemEntity;
using BaseData;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace AndersonSurveySystemData
{
    public class DQuestion : DBase, IDQuestion
    {
        public DQuestion() : base (new Context())
        {

        }
        #region Create
        #endregion

        #region Read
        public List<EQuestion> Read()
        {
            using (var context = new Context())
            {
                return context.Question
                    .OrderBy(a => a.QuestionId)
                    .ToList();
            }
        }
        #endregion

        #region Update
        #endregion

        #region Delete
        #endregion

        #region Other Function
        #endregion
    }
}
        

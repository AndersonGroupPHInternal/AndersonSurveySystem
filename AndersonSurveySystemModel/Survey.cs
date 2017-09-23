using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonSurveySystemModel
{
    public class Survey : Base.Base
    {

        public int SurveyId { get; set; }
        public string SurveyName { get; set; }
        public string Comments { get; set; }
        public int Rate { get; set; }

        public IEnumerable<Question> Result { get; set; }
        //public int Rate { get; set;  }
        public virtual Rate Rates { get; set; }

    }
}

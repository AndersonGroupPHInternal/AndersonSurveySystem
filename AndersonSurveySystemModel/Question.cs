using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonSurveySystemModel
{
    public class Question : Base.Base
    {
        public int QuestionId { get; set; }

        public string Description { get; set; }
        public int Rate { get; set; }
    }
}

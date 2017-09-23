using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonSurveySystemModel
{
    public class AnsweredQuestion
    {
        public int AnsweredQuestionId { get; set; }
        public int AnsweredSurveyId { get; set; }
        public int QuestionId { get; set; }
        public int Rate { get; set; }

        public string Answer { get; set; }
        public string Comments { get; set; }

        //public List<Rate> rate { get; set; }
        //public List<Survey> survey { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonSurveySystemModel
{
    public class AnsweredSurvey
    {
        //public static int AnsweredSurveyId { get; set; }
        //public static int Contractor { get; set; }
        public int AnsweredSurveyId { get; set; }
        //public string ReferenceNumber { get; set; }
        //public int SurveyId { get; set; }
        //public int Userid { get; set; }

        //additional field
        //public int Rate { get; set; }      

        public List<AnsweredQuestion> AnsweredQuestions { get; set; }

        public List<Question> Questions { get; set; }

        public string Name { get; set; }
        public string ticketnumber { get; set; }
        public string description { get; set; }

    }
}

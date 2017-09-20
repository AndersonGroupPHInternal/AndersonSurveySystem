using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonSurveySystemModel
{
    public class Comment : Base.Base
    {
        public int CommentId { get; set; }
        public int SurveyId { get; set; }
        public string Comments { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonSurveySystemModel
{
    public class Chart
    {
        public string Series { get; set; }
        public List<ChartData> ChartData { get; set; }

        public List<AnsweredQuestion> AnsweredQuestion { get; set; }
    }
}

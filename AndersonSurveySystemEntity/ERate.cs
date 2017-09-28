using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonSurveySystemEntity
{
    [Table("Rate")]
    public class ERate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RateId { get; set; }
        public int SurveyId { get; set; }


      public int Rates { get; set; }

        public ICollection<ESurvey> Survey { get; set; }
    }
}

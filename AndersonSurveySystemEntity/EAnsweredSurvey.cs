using BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonSurveySystemEntity
{
    [Table("AnsweredSurvey")]
    public class EAnsweredSurvey
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int AnsweredSurveyid { get; set; }
        public string ReferenceNumber { get; set; }


        //[ForeignKey("Survey")]
        //public int Surveyid { get; set; }

        public ICollection<EAnsweredQuestion> AnsweredQuestion { get; set; }

        public int Userid { get; set; }

    }
}

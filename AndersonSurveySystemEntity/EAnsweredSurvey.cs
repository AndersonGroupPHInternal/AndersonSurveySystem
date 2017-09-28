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
        //public string ReferenceNumber { get; set; }


        public int QuestionId { get; set; }
        //[ForeignKey("Survey")]
        //public int Surveyid { get; set; }

        public ICollection<EAnsweredQuestion> AnsweredQuestions { get; set; }

        public ICollection<EQuestion> Questions { get; set; }

        //additional field
        //public int Rate { get; set; }
        public int Userid { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(50)]
        public string ticketnumber { get; set; }

        [StringLength(250)]
        public string description { get; set; }

    }
}

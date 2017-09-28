using BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonSurveySystemEntity
{
    [Table("AnsweredQuestion")]
    public class EAnsweredQuestion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnsweredQuestionId { get; set; }
        public int QuestionId { get; set; }
        [NotMapped]
        public int Rate { get; set; }

        //[ForeignKey("AnsweredSurvey")]
        //public int AnsweredSurveyid { get; set; }

        //[ForeignKey("Question")]

    
        public int Answer { get; set; }

        [StringLength(250)]
        public string Comments { get; set; }

        public EAnsweredSurvey AnsweredSurvey { get; set; }
        public ESurvey Survey { get; set; }
        public EQuestion Questions { get; set; }
        //public EComment Comments { get; set; }

        public ICollection<EQuestion> Question { get; set; }
    }
}

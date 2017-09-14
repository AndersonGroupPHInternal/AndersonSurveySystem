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
        public int AnsweredQuestionid { get; set; }

        //[ForeignKey("AnsweredSurvey")]
        //public int AnsweredSurveyid { get; set; }

        //[ForeignKey("Question")]
        //public int Questionid { get; set; }

        public ICollection<EQuestion> Question { get; set; }

        [StringLength(50)]
        public string Answer { get; set; }

        public ESurvey Survey { get; set; }
        public EAnsweredSurvey AnsweredSurvey { get; set; }

        public EQuestion Questions { get; set; }
    }
}

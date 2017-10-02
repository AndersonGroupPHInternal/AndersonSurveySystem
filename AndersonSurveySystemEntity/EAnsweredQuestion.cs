using BaseEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonSurveySystemEntity
{
    [Table("AnsweredQuestion")]
    public class EAnsweredQuestion: EBase
    {
        public int Answer { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnsweredQuestionId { get; set; }
        [ForeignKey("AnsweredSurvey")]
        public int AnsweredSurveyid { get; set; }
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        
        public EAnsweredSurvey AnsweredSurvey { get; set; }
        public EQuestion Question { get; set; }
    }
}

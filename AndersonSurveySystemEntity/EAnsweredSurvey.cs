using BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonSurveySystemEntity
{
    [Table("AnsweredSurvey")]
    public class EAnsweredSurvey : EBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnsweredSurveyid { get; set; }
        public int QuestionId { get; set; }
        [ForeignKey("Survey")]
        public int SurveyId { get; set; }

        [StringLength(250)]
        public string Description { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(50)]
        public string TicketNumber { get; set; }

        public ESurvey Survey { get; set; }

        public ICollection<EAnsweredQuestion> AnsweredQuestions { get; set; }
    }
}

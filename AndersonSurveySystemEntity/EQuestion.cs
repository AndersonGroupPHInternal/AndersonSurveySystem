using BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonSurveySystemEntity
{
    [Table("Question")]
    public class EQuestion: EBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionId { get; set; }
        [ForeignKey("Survey")]
        public int SurveyId { get; set; }

        [StringLength(250)]
        public string Description { get; set; }
        public string Name { get; set; }

        public ESurvey Survey { get; set; }

        public ICollection<EAnsweredQuestion> AnsweredQuestions { get; set; }
    }
}

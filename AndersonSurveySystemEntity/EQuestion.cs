using BaseEntity;
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

        [StringLength(50)]
        public string Description { get; set; }

        public ESurvey Survey { get; set; }
    }
}

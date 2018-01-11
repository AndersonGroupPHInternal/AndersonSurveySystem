using BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonSurveySystemEntity
{
    [Table("Survey")]
    public class ESurvey : EBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SurveyId { get; set; }

        [StringLength(250)]
        public string SurveyName { get; set; }

        public ICollection<EAnsweredSurvey> AnsweredSurveys { get; set; }
        public virtual ICollection<EQuestion> Questions { get; set; }
    }
}

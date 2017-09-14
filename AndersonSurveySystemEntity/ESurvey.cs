using BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonSurveySystemEntity
{
    [Table("Survey")]
    public class ESurvey
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SurveyId { get; set; }

        [StringLength(250)]
        public string SurveyName { get; set; }
        //public string Email { get; set; }
        public int Rate { get; set; }
        

        public ICollection<EAnsweredQuestion> AnsweredQuestion { get; set; }
    }
}

using BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonSurveySystemEntity
{
    [Table("Question")]
    public class EQuestion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionId { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public int Rate { get; set; }

        //[ForeignKey("TypeOfQuestion")]
        //public int TypeOfQuestionId { get; set; }

        //public ICollection<EAnsweredQuestion> AnsweredQuestion { get; set; }
        //public ICollection<ETypeOfQuestion> TypeOfQuestion { get; set; }

        //public ETypeOfQuestion TypeOfQuestions { get; set; }
    }
}

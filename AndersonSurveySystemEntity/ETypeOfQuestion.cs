using BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonSurveySystemEntity
{
    [Table("TypeOfQuestion")]
    public class ETypeOfQuestion
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeOfQuestionId { get; set; }

        [StringLength(50)]
        public string TypeOfQuestionName { get; set; }

        public ICollection<EQuestion> Question { get; set; }
    }
}

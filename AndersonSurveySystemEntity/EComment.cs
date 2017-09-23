using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonSurveySystemEntity
{
    [Table("Comment")]
    public class EComment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }
        public int SurveyId { get; set; }

        [StringLength(250)]
        public string Comments { get; set; }



        public ICollection<ESurvey> Survey { get; set; }
    }
}

using BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonSurveySystemEntity
{
    [Table("Admin")]
    public class EAdmin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminId { get; set; }

        [StringLength(250)]
        public string AdminName { get; set; }
        //public string Email { get; set; }
        [StringLength(250)]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        


        public ICollection<EAnsweredSurvey> AnsweredQuestion { get; set; }
    }
}
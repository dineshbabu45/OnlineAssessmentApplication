using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineAssessmentProject.DomainModel
{
    public class Questions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionID { get; set; }

        
        public int TestId { get; set; }
        [ForeignKey("TestId")]
        public Test Test { get; set; }
        public string Question { get; set; }

    }

}

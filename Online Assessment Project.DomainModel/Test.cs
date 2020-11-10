using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineAssessmentProject.DomainModel
{
    public  class Test
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestId { get; set; }

        public string TestName { get; set; }
        public string Status { get; set; }
        public string Subject { get; set; }
        public string ApprovedBy { get; set; }
        public string CreatedTime { get; set; }
        public string ModifiedTime { get; set; }

        public string TestDate { get; set; }
        public string StartTime { get; set; }

        public string EndTime { get; set; }
        public Grade Grade { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

    }
    public enum Grade
    {
        I=1, II, III, IV, V, VI, VII, VIII, IX, X
    }
}



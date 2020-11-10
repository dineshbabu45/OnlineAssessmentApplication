using System.ComponentModel.DataAnnotations;

namespace OnlineAssessmentProject.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateTestViewModel
    {
        public int TestId { get; set; }
        public int UserId { get; set; }
        
        [Display(Name = "Name of the Test")]
        [Required(ErrorMessage = "Test name is required.")]
        public string TestName { get; set; }
        public string Status { get; set; }
        [Required(ErrorMessage = "Date is required.")]
        [Display(Name = "Date")]
        public string TestDate { get; set; }
        [Required(ErrorMessage = "Subject is required.")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Choose Start Time")]
        [Display(Name = "Start Time")]
        public string StartTime { get; set; }
        [Required(ErrorMessage = "Choose End Time")]
        [Display(Name = "End Time")]
        public string EndTime { get; set; }

        [Required]
        public Grade Grade { get; set; }
    }
    public enum Grade
    {
        I=1, II, III, IV, V, VI, VII, VIII, IX, X
    }

}


using System.ComponentModel.DataAnnotations;

namespace OnlineAssessmentProject.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email ID")]
        public string EmailID { get; set; }
        [Required]

        public string Password { get; set; }

        public string Name { get; set; }
    }
}

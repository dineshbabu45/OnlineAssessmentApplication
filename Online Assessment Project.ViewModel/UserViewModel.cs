using System.ComponentModel.DataAnnotations;

namespace Online_Assessment_Project.ViewModel
{
    public class UserViewModel
    {
        [Required]
        [Display(Name ="Email ID")]
        public string EmailID { get; set; }
        [Required]
        
        public string Password { get; set; }

        public string Name { get; set; }
    }
}

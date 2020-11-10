using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnlineAssessmentProject.DomainModel
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string Grade { get; set; }
        public long PhoneNumber { get; set; }
        
        public string CreatedDate { get; set; }
        
        public string ModifiedDate { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId ")]
        public Role Role { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Assessment_Project.DomainModel
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

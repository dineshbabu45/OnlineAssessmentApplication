using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAssessmentProject.DomainModel
{
    public class Answer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnswerID { get; set; }
        public int QuestionID { get; set; }

        [ForeignKey("QuestionID")]
        public Questions Questions { get; set; }
        public char AnswerLable { get; set; }
        public string Description { get; set; }
        public decimal Mark { get; set; }
        public byte IsBool { get; set; }
    }

}

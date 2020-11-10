using OnlineAssessmentProject.DomainModel;
using System.Collections.Generic;
using System.Linq;

namespace OnlineAssessmentProject.Repository
{
    public interface IQuestionRepository
    {
        void InsertQuestion(Questions question);
        void EditQuestion(Questions question);
        void DeleteQuestion(int questionID);
        List<Questions> GetQuestionsByQuestionID(int questionID);
    
            List<Questions> GetQuestions();
    }
    public class QuestionRepository : IQuestionRepository
    {
        AssessmentPortalDbContext assessmentDbContext;
        public QuestionRepository()
        {
            assessmentDbContext = new AssessmentPortalDbContext();
        }
        public void InsertQuestion(Questions question)
        {
            assessmentDbContext.Questions.Add(question);
            assessmentDbContext.SaveChanges();
        }
        public void EditQuestion(Questions question)
        {
            Questions changeQuestion = assessmentDbContext.Questions.Where(temp => temp.QuestionID == question.QuestionID).FirstOrDefault();
            if (changeQuestion != null)
            {
                changeQuestion.Question = question.Question;
                assessmentDbContext.SaveChanges();
            }
        }
        public void DeleteQuestion(int questionID)
        {
            Questions changeQuestion = assessmentDbContext.Questions.Where(temp => temp.QuestionID == questionID).FirstOrDefault();
            if (changeQuestion != null)
            {
                assessmentDbContext.Questions.Remove(changeQuestion);
                assessmentDbContext.SaveChanges();
            }
        }
        public List<Questions> GetQuestions()
        {
            List<Questions> changeQuestion = assessmentDbContext.Questions.OrderByDescending(temp => temp.Question).ToList();
            return changeQuestion;
        }
        public List<Questions> GetQuestionsByQuestionID(int questionID)
        {
            List<Questions> changeQuestion = assessmentDbContext.Questions.Where(temp => temp.QuestionID == questionID).ToList();
            return changeQuestion;
        }
    }
}




using AutoMapper;
using Online_Assessment_Project.DomainModel;
using Online_Assessment_Project.Repository;
using Online_Assessment_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Assessment_Project.ServiceLayer
{
    public interface IQuestionServices
    {
        void InsertQuestion(QuestionsViewModel createQuestionsViewModel);
        void EditQuestion(QuestionsViewModel editQuestionsViewModel);
        void DeleteQuestion(int questionID);
        List<QuestionsViewModel> GetQuestions();
        List<Questions> GetQuestionsByQuestionID(int questionID);

    }
    public class QuestionServices : IQuestionServices
    {
        IQuestionRepository questionRepository;
        public QuestionServices()
        {
            questionRepository = new QuestionRepository();
        }
        public void InsertQuestion(QuestionsViewModel QuestionsViewModel)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<QuestionsViewModel, Questions>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            Questions question = mapper.Map<QuestionsViewModel, Questions>(QuestionsViewModel);
            questionRepository.InsertQuestion(question);
        }
        public void EditQuestion(QuestionsViewModel editQuestionsViewModel)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<QuestionsViewModel, Questions>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            Questions question = mapper.Map<QuestionsViewModel, Questions>(editQuestionsViewModel);
            questionRepository.EditQuestion(question);
        }
        public void DeleteQuestion(int questionID)
        {
            questionRepository.DeleteQuestion(questionID);
        }
        public List<QuestionsViewModel> GetQuestions()
        {
            List<Questions> questionList = questionRepository.GetQuestions();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Questions, QuestionsViewModel>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            List<QuestionsViewModel> questionvm = mapper.Map<List<Questions>, List<QuestionsViewModel>>(questionList);
            return questionvm;
        }
        public List<Questions> GetQuestionsByQuestionID(int questionID)
        {
           List< Questions> question = questionRepository.GetQuestionsByQuestionID(questionID);
            //QuestionsViewModel questionvm = null;
            //if (question != null)
            //{
            //    var config = new MapperConfiguration(cfg => { cfg.CreateMap<Questions, QuestionsViewModel>(); cfg.IgnoreUnmapped(); });
            //    IMapper mapper = config.CreateMapper();
            //    questionvm = mapper.Map<Questions, QuestionsViewModel>(question);
            //}
            return question;
        }
    } 
}
    

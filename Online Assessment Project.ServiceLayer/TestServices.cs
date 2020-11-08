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
    public interface ITestServices
    {
        IEnumerable<Test> DisplayAllDetails(string search);
        void CreateNewTest(CreateTestViewModel testViewModel);
    }

    public class TestServices : ITestServices
    {
        TestRepository testRepository = new TestRepository();
        public void CreateNewTest(CreateTestViewModel testViewModel)
        {
            if (testViewModel != null)
            {

                var config = new MapperConfiguration(cfg => { cfg.CreateMap<CreateTestViewModel, Test>(); cfg.IgnoreUnmapped(); });
                IMapper mapper = config.CreateMapper();
                var test = mapper.Map<CreateTestViewModel, Test>(testViewModel);
                testRepository.CreateNewTest(test);
            }

        }
        public IEnumerable<Test> DisplayAllDetails(string search)
        {
            return testRepository.DisplayAllDetails(search);
        }
    }
}

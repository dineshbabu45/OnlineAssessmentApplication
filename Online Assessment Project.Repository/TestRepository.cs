using Online_Assessment_Project.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Assessment_Project.Repository
{
    interface ITestRepository
    {
        IEnumerable<Test> DisplayAllDetails(string search);
        void CreateNewTest(Test test);
        Test GetTestByTestId(int testId);
    }
    public class TestRepository : ITestRepository
    {
        AssessmentPortalDbContext db;
        public TestRepository()
        {
            db = new AssessmentPortalDbContext();
        }
        public void CreateNewTest(Test test) //To create new test
        {
            test.CreatedTime = DateTime.Now.ToString();
            db.Tests.Add(test);
            db.SaveChanges();

        }
        public Test GetTestByTestId(int testId)
        {
            return db.Tests.Find(testId);
        }
    

    
        public IEnumerable<Test> DisplayAllDetails(string search)
        {
            
                IEnumerable<Test> tests =db.Tests.Where(test => test.Subject.Contains(search) || search == null).ToList();
                return tests;
            
        }
    }
}

using OnlineAssessmentProject.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineAssessmentProject.Repository
{
    public interface ITestRepository
    {
        IEnumerable<Test> DisplayAllDetails();
        void CreateNewTest(Test test);
        Test GetTestByTestId(int testId);
        void UpdateTest(Test editTest);
    }
    public class TestRepository : ITestRepository
    {
        readonly AssessmentPortalDbContext db;
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

        public void UpdateTest(Test editTest)
        {
            editTest.ModifiedTime = DateTime.Now.ToString();
            Test test = db.Tests.Find(editTest.TestId);
            if (test != null)
            {
                test.TestId = editTest.TestId;
                test.TestName =editTest.TestName;
                test.TestDate = editTest.TestDate;
                test.StartTime = editTest.StartTime;
                test.EndTime = editTest.EndTime;
                test.Grade = editTest.Grade;
                test.Subject = editTest.Subject;
                
                test.ModifiedTime = editTest.ModifiedTime;
                db.SaveChanges();
            }

        }
        public Test GetTestByTestId(int testId)
        {
            return db.Tests.Find(testId);
        }
    

    
        public IEnumerable<Test> DisplayAllDetails()
        {
            IEnumerable<Test> allTests = db.Tests.OrderByDescending(temp => temp.TestDate).ToList();
            return allTests;
            
        }
    }
}

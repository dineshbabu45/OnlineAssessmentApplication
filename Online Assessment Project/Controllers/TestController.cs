using OnlineAssessmentProject.ServiceLayer;
using OnlineAssessmentProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OnlineAssessmentProject.Controllers
{
    public class TestController : Controller
    {
        readonly ITestService testService;
        
        public TestController(ITestService testService)
        {
            this.testService=testService;
        }
        // GET: Test
        
        public ActionResult CreateTest()
        {

            return View();
        }
        [HttpPost]
        [ActionName("CreateTest")]
        public ActionResult SaveTest(CreateTestViewModel newTest)//Create Test
        {
            newTest.UserId = Convert.ToInt32(Session["CurrentUserID"]);
            if (ModelState.IsValid)
            {
                testService.CreateNewTest(newTest);
            }
            return View();
        }
        public ActionResult EditTest(int testId)
        {
            
            TestViewModel test = testService.GetTestByTestId(testId);
            return View(test);
        }
        [HttpPost]
        public ActionResult EditTest(EditTestViewModel editedData)
        {
            if (ModelState.IsValid)
            {
                editedData.UserId = Convert.ToInt32(Session["CurrentUserID"]);
                testService.UpdateTest(editedData);
            }
                return RedirectToAction("DisplayAvailableTest");
        }
        public ActionResult DisplayAvailableTest()
        {
            IEnumerable<TestViewModel> test = testService.DisplayAllDetails();
            return View(test);
        }
        public ActionResult Display()
        {
            return View();
        }
    }
}
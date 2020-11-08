using Online_Assessment_Project.DomainModel;
using Online_Assessment_Project.ServiceLayer;
using Online_Assessment_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Assessment_Project.Controllers
{
    public class TestController : Controller
    {
        ITestServices testServices;
        
        public TestController()
        {
            testServices = new TestServices();
        }
        // GET: Test
        public ActionResult CreateTest()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CreateTest(CreateTestViewModel newTest)
        {

            if (ModelState.IsValid)
            {
                testServices.CreateNewTest(newTest);
            }
            return View();
        }
        public ActionResult DisplayAvailableTest(string search)
        {
            IEnumerable<Test> test = testServices.DisplayAllDetails(search);
            return View(test);
        }
        public ActionResult Display()
        {
            return View();
        }
    }
}
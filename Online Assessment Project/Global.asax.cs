using OnlineAssessmentProject.App_Start;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;

namespace OnlineAssessmentProject
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            UnityConfig.RegisterComponents();
        }
    }
}

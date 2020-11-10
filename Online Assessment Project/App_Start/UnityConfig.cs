using OnlineAssessmentProject.ServiceLayer;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace OnlineAssessmentProject
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IRoleService, RoleService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
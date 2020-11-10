using OnlineAssessmentProject.DomainModel;
using OnlineAssessmentProject.Repository;
using System.Collections.Generic;

namespace OnlineAssessmentProject.ServiceLayer
{
    public interface IRoleService
    {
        List<Role> Display();
    }
    public class RoleService : IRoleService
    {
        readonly IRoleRepository RoleRepository;
        public RoleService()
        {
            RoleRepository = new RoleRepository();
        }
        public List<Role> Display()
        {
            return (RoleRepository.Display());
        }
    }
}

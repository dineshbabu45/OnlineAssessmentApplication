using OnlineAssessmentProject.DomainModel;
using System.Collections.Generic;
using System.Linq;

namespace OnlineAssessmentProject.Repository
{
    public interface IRoleRepository
    {
        List<Role> Display();
    }
        public class RoleRepository:IRoleRepository
   {
        AssessmentPortalDbContext db;


        public RoleRepository()
        {
            db = new AssessmentPortalDbContext();
        }
        public List<Role> Display()
        {
            
            List<Role> data = db.Roles.ToList();
            return (data);

        }
    }
}

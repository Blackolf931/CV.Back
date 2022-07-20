using CV.DAL.EF;
using CV.DAL.Entities;

namespace CV.DAL.Repositories
{
    public class ProjectRepository : GenericRepository<ProjectEntity>
    {
        public ProjectRepository(ApplicationContext context) : base(context)
        {
        }
    }
}

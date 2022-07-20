using CV.DAL.EF;
using CV.DAL.Entities;
using CV.DAL.Interfaces;

namespace CV.DAL.Repositories
{
    public class ProjectRepository : GenericRepository<ProjectEntity>, IGenericRepository<ProjectEntity>
    {
        public ProjectRepository(ApplicationContext context) : base(context)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

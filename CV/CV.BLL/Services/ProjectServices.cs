using AutoMapper;
using CV.BLL.Interfaces;
using CV.BLL.Models;
using CV.DAL.Entities;
using CV.DAL.Interfaces;

namespace CV.BLL.Services
{
    public class ProjectServices : GenericServices<ProjectModel, ProjectEntity>, IGenericServices<ProjectModel>
    {
        public ProjectServices(IGenericRepository<ProjectEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}

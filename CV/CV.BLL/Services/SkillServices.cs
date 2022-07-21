using AutoMapper;
using CV.BLL.Interfaces;
using CV.BLL.Models;
using CV.DAL.Entities;
using CV.DAL.Interfaces;

namespace CV.BLL.Services
{
    public class SkillServices : GenericServices<SkillModel, SkillEntity>, ISkillServices
    {
        public SkillServices(IGenericRepository<SkillEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}

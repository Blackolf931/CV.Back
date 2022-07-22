using AutoMapper;
using CV.BLL.Interfaces;
using CV.BLL.Models;
using CV.DAL.Entities.Skill;
using CV.DAL.Interfaces;

namespace CV.BLL.Services
{
    public class SkillGroupServices : GenericServices<SkillGroupModel, SkillGroupEntity>, ISkillGroupServices
    {
        public SkillGroupServices(IGenericRepository<SkillGroupEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}

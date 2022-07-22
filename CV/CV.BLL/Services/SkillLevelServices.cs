using AutoMapper;
using CV.BLL.Interfaces;
using CV.BLL.Models;
using CV.DAL.Entities.Skill;
using CV.DAL.Interfaces;

namespace CV.BLL.Services
{
    public class SkillLevelServices : GenericServices<SkillLevelModel, SkillLevelEntity>, ISkillLevelServices
    {
        public SkillLevelServices(IGenericRepository<SkillLevelEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}

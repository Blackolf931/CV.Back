using CV.DAL.EF;
using CV.DAL.Entities.Skill;

namespace CV.DAL.Repositories.Skill
{
    public class SkillGroupRepository : GenericRepository<SkillGroupEntity>
    {
        public SkillGroupRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
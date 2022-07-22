using CV.DAL.EF;
using CV.DAL.Entities.Skill;

namespace CV.DAL.Repositories.Skill
{
    public class SkillRepository : GenericRepository<SkillEntity>
    {
        public SkillRepository(ApplicationContext context) : base(context)
        {
        }
    }
}

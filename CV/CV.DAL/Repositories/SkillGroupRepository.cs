using CV.DAL.EF;
using CV.DAL.Entities;

namespace CV.DAL.Repositories
{
    public class SkillGroupRepository : GenericRepository<SkillGroupEntity>
    {
        public SkillGroupRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
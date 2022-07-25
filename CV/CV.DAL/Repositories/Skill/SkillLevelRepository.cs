﻿using CV.DAL.EF;
using CV.DAL.Entities.Skill;

namespace CV.DAL.Repositories.Skill
{
    public class SkillLevelRepository : GenericRepository<SkillLevelEntity>
    {
        public SkillLevelRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
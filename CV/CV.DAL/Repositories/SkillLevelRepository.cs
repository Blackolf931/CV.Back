﻿using CV.DAL.EF;
using CV.DAL.Entities;

namespace CV.DAL.Repositories
{
    public class SkillLevelRepository : GenericRepository<SkillLevelEntity>
    {
        public SkillLevelRepository(ApplicationContext context) : base(context)
        {
        }
    }
}

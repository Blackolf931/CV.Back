using CV.DAL.Entities;
using CV.DAL.Entities.ForeignLanguage;
using CV.DAL.Entities.Skill;
using Microsoft.EntityFrameworkCore;

namespace CV.DAL.EF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<EmployeeEntity> Employees { get; set; } = null!;
        public DbSet<ProjectEntity> Projects { get; set; } = null!;
        public DbSet<SkillEntity> Skills { get; set; } = null!;
        public DbSet<SkillGroupEntity> SkillGroups { get; set; } = null!;
        public DbSet<SkillLevelEntity> SkillLevels { get; set; } = null!;
        public DbSet<ForeignLanguageEntity> ForeignLanguages { get; set; } = null!;
        public DbSet<LanguageEverydayTopicEntity> LanguageEverydayTopics { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.Migrate();
        }
    }
}
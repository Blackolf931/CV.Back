using CV.DAL.EF;
using CV.DAL.Entities.ForeignLanguage;

namespace CV.DAL.Repositories.ForeignLanguage
{
    public class LanguageLevelRepository : GenericRepository<LanguageLevelEntity>
    {
        public LanguageLevelRepository(ApplicationContext context) : base(context)
        {
        }
    }
}

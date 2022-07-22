using CV.DAL.EF;
using CV.DAL.Entities.ForeignLanguage;

namespace CV.DAL.Repositories.ForeignLanguage
{
    public class ForeignLanguageRepository : GenericRepository<ForeignLanguageEntity>
    {
        public ForeignLanguageRepository(ApplicationContext context) : base(context)
        {
        }
    }
}

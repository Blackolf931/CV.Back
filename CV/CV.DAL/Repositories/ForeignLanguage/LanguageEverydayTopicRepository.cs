using CV.DAL.EF;
using CV.DAL.Entities.ForeignLanguage;

namespace CV.DAL.Repositories.ForeignLanguage
{
    public class LanguageEverydayTopicRepository : GenericRepository<LanguageEverydayTopicEntity>
    {
        public LanguageEverydayTopicRepository(ApplicationContext context) : base(context)
        {
        }
    }
}

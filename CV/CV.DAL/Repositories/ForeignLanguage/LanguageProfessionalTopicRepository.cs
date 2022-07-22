using CV.DAL.EF;
using CV.DAL.Entities.ForeignLanguage;

namespace CV.DAL.Repositories.ForeignLanguage
{
    public class LanguageProfessionalTopicRepository : GenericRepository<LanguageProfessionalTopicEntity>
    {
        public LanguageProfessionalTopicRepository(ApplicationContext context) : base(context)
        {
        }
    }
}

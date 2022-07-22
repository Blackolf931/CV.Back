using AutoMapper;
using CV.BLL.Interfaces.ForeignLanguage;
using CV.BLL.Models.ForeignLanguage;
using CV.DAL.Entities.ForeignLanguage;
using CV.DAL.Interfaces;

namespace CV.BLL.Services.ForeignLanguage
{
    public class LanguageProfessionalTopicServices : GenericServices<LanguageProfessionalTopicModel, LanguageProfessionalTopicEntity>, ILanguageProfessionalTopicServices
    {
        public LanguageProfessionalTopicServices(IGenericRepository<LanguageProfessionalTopicEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}

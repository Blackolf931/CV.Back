using AutoMapper;
using CV.BLL.Interfaces.ForeignLanguage;
using CV.BLL.Models.ForeignLanguage;
using CV.DAL.Entities.ForeignLanguage;
using CV.DAL.Interfaces;

namespace CV.BLL.Services.ForeignLanguage
{
    public class LanguageEverydayTopicServices : GenericServices<LanguageEverydayTopicModel, LanguageEverydayTopicEntity>, ILanguageEverydayTopicServices
    {
        public LanguageEverydayTopicServices(IGenericRepository<LanguageEverydayTopicEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}

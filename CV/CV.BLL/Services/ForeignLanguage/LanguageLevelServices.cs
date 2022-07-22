using AutoMapper;
using CV.BLL.Interfaces.ForeignLanguage;
using CV.BLL.Models.ForeignLanguage;
using CV.DAL.Entities.ForeignLanguage;
using CV.DAL.Interfaces;

namespace CV.BLL.Services.ForeignLanguage
{
    public class LanguageLevelServices : GenericServices<LanguageLevelModel, LanguageLevelEntity>, ILanguageLevelServices
    {
        public LanguageLevelServices(IGenericRepository<LanguageLevelEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}

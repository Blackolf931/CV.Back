using AutoMapper;
using CV.BLL.Interfaces.ForeignLanguage;
using CV.BLL.Models.ForeignLanguage;
using CV.DAL.Entities.ForeignLanguage;
using CV.DAL.Interfaces;

namespace CV.BLL.Services.ForeignLanguage
{
    public class ForeignLanguageServices : GenericServices<ForeignLanguageModel, ForeignLanguageEntity>, IForeignLanguageServices
    {
        public ForeignLanguageServices(IGenericRepository<ForeignLanguageEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}

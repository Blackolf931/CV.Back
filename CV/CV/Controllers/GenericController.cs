using Microsoft.AspNetCore.Mvc;

namespace CV.API.Controllers
{
    public class GenericController<TViewModel, TShortModel, TChangeModel, TModel> : Controller
        where TViewModel : class
        where TShortModel : class
        where TChangeModel : class
        where TModel : class
    {
        private readonly IGenericService _genericService;
        private readonly IMapper _mapper;

        public GenericController(
            IGenericService genericService,
            IMapper mapper)
        {
            _mapper = mapper;
            _genericService = genericService;
        }

        [HttpGet]
        public async Task<IEnumerable<TViewModel>> GetAll(CancellationToken token)
        {
            var result = await _genericService.GetAll(token);

            return _mapper.Map<IEnumerable<TViewModel>>(result);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id,
            CancellationToken token)
        {
            await _genericService.Delete(id, token);
        }

        [HttpPut("{id}")]
        public async Task<TShortModel> Update(TChangeModel tChangeModel, int id,
            CancellationToken token)
        {
            var tModel = _mapper.Map<TModel>(tChangeModel);
            tModel.Id = id;
            var result = await _genericService.Update(tModel, token);

            return _mapper.Map<TShortModel>(result);
        }

        [HttpPost]
        public async Task<TShortModel> Create(TChangeModel tChangeModel,
            CancellationToken token)
        {
            var tModel = _mapper.Map<TModel>(tChangeModel);
            var result = await _genericService.Create(tModel, token);

            return _mapper.Map<TShortModel>(result);
        }
    }
}
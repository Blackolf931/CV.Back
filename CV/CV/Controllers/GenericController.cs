using AutoMapper;
using CV.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CV.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class GenericController<TViewModel, TShortModel, TAddModel, TModel, TUpdateModel> : ControllerBase
        where TViewModel : class
        where TShortModel : class
        where TAddModel : class
        where TUpdateModel : class
        where TModel : class
    {
        private readonly IGenericServices<TModel> _genericService;
        private readonly IMapper _mapper;

        public GenericController(
            IGenericServices<TModel> genericService,
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


        [HttpGet("{id}")]
        public async Task<IEnumerable<TViewModel>> GetById(int id, CancellationToken token)
        {
            var result = await _genericService.GetById(id, token);

            return _mapper.Map<IEnumerable<TViewModel>>(result);
        }

        [HttpDelete("{id}")]
        public async Task DeleteById(int id,
            CancellationToken token)
        {
            await _genericService.DeleteById(id, token);
        }

        [HttpPut]
        public virtual async Task<TShortModel> Update(TUpdateModel tChangeModel,
            CancellationToken token)
        {
            var tModel = _mapper.Map<TModel>(tChangeModel);
            var result = await _genericService.Update(tModel, token);

            return _mapper.Map<TShortModel>(result);
        }

        [HttpPost]
        public async Task<TShortModel> Create(TAddModel tChangeModel,
            CancellationToken token)
        {
            var tModel = _mapper.Map<TModel>(tChangeModel);
            var result = await _genericService.Create(tModel, token);

            return _mapper.Map<TShortModel>(result);
        }
    }
}
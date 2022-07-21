using AutoMapper;
using CV.BLL.Interfaces;
using CV.DAL.Infraestructure;
using CV.DAL.Interfaces;

namespace CV.BLL.Services
{
    public class GenericServices<TModel, TEntity> : IGenericServices<TModel>
        where TModel : class
        where TEntity : HasId
    {
        protected readonly IGenericRepository<TEntity> repository;

        protected readonly IMapper mapper;

        public GenericServices(IGenericRepository<TEntity> genericRepository, IMapper mapper)
        {
            repository = genericRepository;
            this.mapper = mapper;
        }

        public async Task<TModel> Create(TModel model, CancellationToken ct)
        {
            var resultEntity = await repository.Create(mapper.Map<TEntity>(model), ct);

            return mapper.Map<TModel>(resultEntity);
        }

        public async Task DeleteById(int id, CancellationToken ct)
        {
            var resultEntity = await repository.GetById(id, ct);

            await repository.Delete(resultEntity, ct);
        }

        public async Task<IEnumerable<TModel>> GetAll(CancellationToken ct)
        {
            var result = mapper.Map<IEnumerable<TModel>>(await repository.GetAll(ct));

            return result;
        }

        public async Task<TModel> GetById(int id, CancellationToken ct)
        {
            var resultEntity = await repository.GetById(id, ct);

            return mapper.Map<TModel>(resultEntity);
        }

        public async Task<TModel> Update(int id, TModel model, CancellationToken ct)
        {
            var entity = mapper.Map<TEntity>(model);
            entity.Id = id;

            var resultEntity = await repository.Update(entity, ct);

            return mapper.Map<TModel>(resultEntity);
        }
    }
}

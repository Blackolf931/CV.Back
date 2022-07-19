using CV.BLL.Interfaces;
using CV.DAL.Interfaces;

namespace CV.BLL.Services
{
    public class GenericServices<TModel, TEntity> : IGenericServices<TModel> where TModel : class where TEntity : class
    {
        protected readonly IGenericRepository<TEntity> repository;

        public GenericServices(IGenericRepository<TEntity> genericRepository)
        {
            repository = genericRepository;
        }

        public Task<TModel> Create(TModel model, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TModel>> GetAll(CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<TModel> GetById(int id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<TModel> Update(TModel model, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}

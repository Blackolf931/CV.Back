namespace CV.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll(CancellationToken token);
        Task<TEntity> GetById(int id, CancellationToken token);
        Task<TEntity> Update(TEntity item, CancellationToken token);
        Task<TEntity> Create(TEntity entity, CancellationToken token);
        Task Delete(TEntity item, CancellationToken token);
    }
}
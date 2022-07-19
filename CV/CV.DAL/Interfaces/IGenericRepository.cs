namespace CV.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<TEntity> UpdateById(TEntity item);
        Task<TEntity> Create(TEntity entity);
        Task DeleteById(int id);
    }
}
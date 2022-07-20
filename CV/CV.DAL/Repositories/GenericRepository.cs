using CV.DAL.EF;
using CV.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CV.DAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationContext context;

        protected readonly DbSet<TEntity> dbSet;

        public GenericRepository(ApplicationContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll(CancellationToken token)
        {
            return await dbSet.AsNoTracking().ToListAsync(token);
        }

        public virtual async Task<TEntity> Create(TEntity tEntity, CancellationToken token)
        {
            await dbSet.AddAsync(tEntity, token);

            await context.SaveChangesAsync(token);

            return tEntity;
        }

        public virtual async Task<TEntity> Update(TEntity tEntity, CancellationToken token)
        {
            dbSet.Update(tEntity);

            await context.SaveChangesAsync(token);

            return tEntity;
        }

        public virtual async Task<TEntity?> GetById(int id, CancellationToken token)
        {
            return await dbSet.FindAsync(new object[] { id }, token);
        }

        public virtual async Task Delete(TEntity tEntity, CancellationToken token)
        {
            dbSet.Remove(tEntity);

            await context.SaveChangesAsync(token);
        }
    }
}
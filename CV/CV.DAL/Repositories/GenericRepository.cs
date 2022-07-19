using CV.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace CV.DAL.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(ApplicationContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public virtual async Task<TEntity> Create(TEntity tEntity)
        {
            await _dbSet.AddAsync(tEntity);

            await _context.SaveChangesAsync();

            return tEntity;
        }

        public virtual async Task<TEntity> Update(TEntity tEntity)
        {
            _dbSet.Update(tEntity);

            await _context.SaveChangesAsync();

            return tEntity;
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            return await _dbSet.FindAsync(new object[] { id });
        }

        public virtual async Task Delete(TEntity tEntity)
        {
            _dbSet.Remove(tEntity);

            await _context.SaveChangesAsync();
        }
    }
}
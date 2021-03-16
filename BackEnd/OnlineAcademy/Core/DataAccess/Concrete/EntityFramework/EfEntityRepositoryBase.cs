using Core.DataAccess.Abstract;
using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        private readonly DbContext _context;

        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            return await _context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Update(entity); });
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

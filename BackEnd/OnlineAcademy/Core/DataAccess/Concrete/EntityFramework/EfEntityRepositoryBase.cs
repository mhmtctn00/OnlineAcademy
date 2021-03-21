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
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                await Task.Run(() => { context.Entry<TEntity>(entity).State = EntityState.Added; });
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                await Task.Run(() => { context.Entry<TEntity>(entity).State = EntityState.Deleted; });
                await context.SaveChangesAsync();
            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {

            using (TContext context = new TContext())
            {
                return await context.Set<TEntity>().FirstOrDefaultAsync(predicate);
            }
        }

        public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            using (TContext context = new TContext())
            {
                if (predicate == null)
                    return await context.Set<TEntity>().ToListAsync();
                else
                    return await context.Set<TEntity>().Where(predicate).ToListAsync();
            }

        }

        public async Task UpdateAsync(TEntity entity)
        {

            using (TContext context = new TContext())
            {
                await Task.Run(() => { context.Entry<TEntity>(entity).State = EntityState.Modified; });
                await context.SaveChangesAsync();
            }
        }
    }
}

using Core.DataAccess.Concrete.EntityFramework;
using Core.Utilities.Results.Abstract;
using Microsoft.EntityFrameworkCore;
using OnlineAcademy.DataAccess.Abstract;
using OnlineAcademy.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category>, ICategoryDal
    {
        private readonly DbContext _context;

        public EfCategoryDal(DbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Category> GetWithCoursesAsync(Expression<Func<Category, bool>> predicate)
        {
            var data = await _context.Set<Category>()
                .Include(c => c.CourseCategories)
                .ThenInclude(c => c.Course).FirstOrDefaultAsync(predicate);
            return data;
        }
    }
}

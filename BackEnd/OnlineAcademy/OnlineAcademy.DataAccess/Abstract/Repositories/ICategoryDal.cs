using Core.DataAccess.Abstract;
using Core.Utilities.Results.Abstract;
using OnlineAcademy.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        Task<Category> GetWithCoursesAsync(Expression<Func<Category, bool>> predicate);
        //Task<IEnumerable<Category>> GetListWithCoursesAsync(Expression<Func<Category, bool>> predicate = null);
    }
}

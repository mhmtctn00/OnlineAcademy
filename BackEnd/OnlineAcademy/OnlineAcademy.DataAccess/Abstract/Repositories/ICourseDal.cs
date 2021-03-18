using Core.DataAccess.Abstract;
using Core.Utilities.Results.Abstract;
using OnlineAcademy.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.DataAccess.Abstract
{
    public interface ICourseDal : IEntityRepository<Course>
    {
        public Task<IEnumerable<Course>> GetCoursesWithIncludesAsync();
        public Task<Course> GetCourseWithIncludesByIdAsync(int id);
    }
}

using Core.DataAccess.Concrete.EntityFramework;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Microsoft.EntityFrameworkCore;
using OnlineAcademy.DataAccess.Abstract;
using OnlineAcademy.DataAccess.Concrete.EntityFramework.Contexts;
using OnlineAcademy.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, EfOnlineAcademyContext>, ICourseDal
    {

        public async Task<IEnumerable<Course>> GetCoursesWithIncludesAsync()
        {
            using (EfOnlineAcademyContext context = new EfOnlineAcademyContext())
            {
                var data = await context.Set<Course>()
                                .Include(c => c.CourseInstructors).ThenInclude(t => t.User)
                                .Include(c => c.CourseCategories).ThenInclude(c => c.Category)
                                .Include(c => c.CourseStudents)
                                .Include(c => c.Sections).ThenInclude(s => s.Lessons).ThenInclude(l => l.Comments).ThenInclude(c => c.User)
                                .ToListAsync();
                return data;
            }

        }
        public async Task<Course> GetCourseWithIncludesByIdAsync(int id)
        {
            using (EfOnlineAcademyContext context = new EfOnlineAcademyContext())
            {
                var data = await context.Set<Course>()
                                .Include(c => c.CourseInstructors).ThenInclude(t => t.User)
                                .Include(c => c.CourseCategories).ThenInclude(c => c.Category)
                                .Include(c => c.CourseStudents)
                                .Include(c => c.Sections).ThenInclude(s => s.Lessons).ThenInclude(l => l.Comments).ThenInclude(c => c.User)
                                .FirstOrDefaultAsync(c => c.Id == id);
                return data;
            }

        }
    }
}

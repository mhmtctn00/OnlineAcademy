using Core.DataAccess.Concrete.EntityFramework;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Microsoft.EntityFrameworkCore;
using OnlineAcademy.DataAccess.Abstract;
using OnlineAcademy.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfCourseDal : EfEntityRepositoryBase<Course>, ICourseDal
    {
        private readonly DbContext _context;
        public EfCourseDal(DbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Course>> GetCoursesWithIncludesAsync()
        {
            var data = await _context.Set<Course>()
                .Include(c => c.CourseTeachers).ThenInclude(t => t.User)
                .Include(c => c.CourseCategories).ThenInclude(c => c.Category)
                .Include(c => c.CourseStudents)
                .Include(c => c.Sections).ThenInclude(s => s.Lessons).ThenInclude(l => l.Comments).ThenInclude(c => c.User)
                .ToListAsync();
            return data;
        }
        public async Task<Course> GetCourseWithIncludesByIdAsync(int id)
        {
            var data = await _context.Set<Course>()
                .Include(c => c.CourseTeachers).ThenInclude(t => t.User)
                .Include(c => c.CourseCategories).ThenInclude(c=>c.Category)
                .Include(c => c.CourseStudents)
                .Include(c => c.Sections).ThenInclude(s => s.Lessons).ThenInclude(l => l.Comments).ThenInclude(c => c.User)
                .FirstOrDefaultAsync(c => c.Id == id);
            return data;
        }
    }
}

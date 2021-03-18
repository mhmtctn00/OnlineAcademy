using Core.Utilities.Results.Abstract;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Abstract
{
    public interface ICourseService
    {
        Task<IResult> AddAsync(Course course);
        Task<IResult> UpdateAsync(Course course);
        Task<IResult> DeleteAsync(Course course);
        Task<IResult> HardDeleteAsync(Course course);
        Task<IDataResult<Course>> GetByCourseIdAsync(int id);
        Task<IDataResult<IEnumerable<CourseDto>>> GetAllAsync();
    }
}

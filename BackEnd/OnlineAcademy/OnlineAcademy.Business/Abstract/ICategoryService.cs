using Core.Utilities.Results.Abstract;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Abstract
{
    public interface ICategoryService
    {
        Task<IResult> AddAsync(Category course);
        Task<IResult> UpdateAsync(Category course);
        Task<IResult> DeleteAsync(Category course);
        Task<IResult> HardDeleteAsync(Category course);
        Task<IDataResult<CategoryDto>> GetByCategoryIdAsync(int id);
        Task<IDataResult<CategoryWithCoursesDto>> GetWithCoursesByIdAsync(int id);
        Task<IDataResult<IEnumerable<CategoryDto>>> GetAllAsync();
    }
}

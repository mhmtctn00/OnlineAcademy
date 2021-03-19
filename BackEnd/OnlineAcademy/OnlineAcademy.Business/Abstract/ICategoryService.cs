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
        Task<IResult> AddAsync(CategoryGetDto course);
        Task<IResult> UpdateAsync(CategoryGetDto course);
        Task<IResult> DeleteAsync(CategoryGetDto course);
        Task<IResult> HardDeleteAsync(CategoryGetDto course);
        Task<IDataResult<CategoryGetDto>> GetByIdAsync(int id);
        Task<IDataResult<CategoryWithCoursesGetDto>> GetWithCoursesByIdAsync(int id);
        Task<IDataResult<IEnumerable<CategoryGetDto>>> GetAllAsync();
    }
}

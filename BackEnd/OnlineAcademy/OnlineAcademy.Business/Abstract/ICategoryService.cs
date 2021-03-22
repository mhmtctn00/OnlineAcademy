using Core.Utilities.Results.Abstract;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos.Get;
using OnlineAcademy.Entities.Dtos.Add;
using OnlineAcademy.Entities.Dtos.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Abstract
{
    public interface ICategoryService
    {
        Task<IResult> AddAsync(CategoryAddDto course);
        Task<IResult> UpdateAsync(CategoryUpdateDto course);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> HardDeleteAsync(int id);
        Task<IDataResult<CategoryGetDto>> GetByIdAsync(int id);
        Task<IDataResult<CategoryWithCoursesGetDto>> GetWithCoursesByIdAsync(int id);
        Task<IDataResult<IEnumerable<CategoryGetDto>>> GetAllAsync();
    }
}

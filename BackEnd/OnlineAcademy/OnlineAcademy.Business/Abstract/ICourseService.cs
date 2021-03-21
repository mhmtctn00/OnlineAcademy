using Core.Utilities.Results.Abstract;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos;
using OnlineAcademy.Entities.Dtos.Add;
using OnlineAcademy.Entities.Dtos.Get;
using OnlineAcademy.Entities.Dtos.Update;
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
        Task<IResult> AddAsync(CourseAddDto course);
        Task<IResult> UpdateAsync(CourseUpdateDto course);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> HardDeleteAsync(int id);
        Task<IDataResult<CourseDetailsGetDto>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<CourseWithInstructorsGetDto>>> GetAllAsync();
    }
}

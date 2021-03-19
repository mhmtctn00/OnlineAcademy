using Core.Utilities.Results.Abstract;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos;
using OnlineAcademy.Entities.Dtos.Get;
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
        Task<IResult> AddAsync(CourseWithInstructorsGetDto course);
        Task<IResult> UpdateAsync(CourseWithInstructorsGetDto course);
        Task<IResult> DeleteAsync(CourseWithInstructorsGetDto course);
        Task<IResult> HardDeleteAsync(CourseWithInstructorsGetDto course);
        Task<IDataResult<CourseDetailsGetDto>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<CourseWithInstructorsGetDto>>> GetAllAsync();
    }
}

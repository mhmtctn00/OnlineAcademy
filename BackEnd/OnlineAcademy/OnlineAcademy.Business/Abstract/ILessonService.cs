using Core.Utilities.Results.Abstract;
using OnlineAcademy.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Abstract
{
    public interface ILessonService
    {
        Task<IResult> AddAsync(LessonGetDto lessonDto);
        Task<IResult> UpdateAsync(LessonGetDto lessonDto);
        Task<IResult> DeleteAsync(LessonGetDto lessonDto);
        Task<IResult> HardDeleteAsync(LessonGetDto lessonDto);
        Task<IDataResult<LessonGetDto>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<LessonGetDto>>> GetAllAsync();
    }
}

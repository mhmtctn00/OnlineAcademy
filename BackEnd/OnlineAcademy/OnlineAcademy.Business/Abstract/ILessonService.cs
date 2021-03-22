using Core.Utilities.Results.Abstract;
using OnlineAcademy.Entities.Dtos.Add;
using OnlineAcademy.Entities.Dtos.Get;
using OnlineAcademy.Entities.Dtos.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Abstract
{
    public interface ILessonService
    {
        Task<IResult> AddAsync(LessonAddDto lessonDto);
        Task<IResult> UpdateAsync(LessonUpdateDto lessonDto);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> HardDeleteAsync(int id);
        Task<IDataResult<LessonGetDto>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<LessonGetDto>>> GetAllAsync();
    }
}

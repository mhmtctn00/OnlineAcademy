using Core.Utilities.Results.Abstract;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Concrete
{
    public class LessonManager : ILessonService
    {
        public Task<IResult> AddAsync(LessonGetDto lessonDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(LessonGetDto lessonDto)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IEnumerable<LessonGetDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<LessonGetDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDeleteAsync(LessonGetDto lessonDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(LessonGetDto lessonDto)
        {
            throw new NotImplementedException();
        }
    }
}

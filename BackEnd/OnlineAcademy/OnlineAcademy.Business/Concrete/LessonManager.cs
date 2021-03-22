using AutoMapper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.DataAccess.Abstract;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos.Add;
using OnlineAcademy.Entities.Dtos.Get;
using OnlineAcademy.Entities.Dtos.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Concrete
{
    public class LessonManager : ILessonService
    {
        private readonly ILessonDal _lessonDal;
        private readonly IMapper _mapper;

        public LessonManager(ILessonDal lessonDal, IMapper mapper)
        {
            _lessonDal = lessonDal;
            _mapper = mapper;
        }

        public async Task<IResult> AddAsync(LessonAddDto lessonDto)
        {
            var lesson = _mapper.Map<LessonAddDto, Lesson>(lessonDto);
            await _lessonDal.AddAsync(lesson);
            return new SuccessResult("Lesson Added.");
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            var lesson = await _lessonDal.GetAsync(l => l.Id == id);
            lesson.IsDeleted = true;
            await _lessonDal.UpdateAsync(lesson);
            return new SuccessResult("Lesson deleted.");
        }

        public async Task<IDataResult<IEnumerable<LessonGetDto>>> GetAllAsync()
        {
            var lessons = await _lessonDal.GetListAsync();
            return new SuccessDataResult<IEnumerable<LessonGetDto>>(_mapper.Map<IEnumerable<Lesson>, IEnumerable<LessonGetDto>>(lessons));
        }

        public async Task<IDataResult<LessonGetDto>> GetByIdAsync(int id)
        {
            var lesson = await _lessonDal.GetAsync(l => l.Id == id);
            return new SuccessDataResult<LessonGetDto>(_mapper.Map<Lesson, LessonGetDto>(lesson));
        }

        public async Task<IResult> HardDeleteAsync(int id)
        {
            var lesson = await _lessonDal.GetAsync(l => l.Id == id);
            await _lessonDal.DeleteAsync(lesson);
            return new SuccessResult("Lesson hard deleted.");
        }

        public async Task<IResult> UpdateAsync(LessonUpdateDto lessonDto)
        {
            var lesson = _mapper.Map<LessonUpdateDto, Lesson>(lessonDto);
            await _lessonDal.UpdateAsync(lesson);
            return new SuccessResult("Lesson updated.");
        }
    }
}

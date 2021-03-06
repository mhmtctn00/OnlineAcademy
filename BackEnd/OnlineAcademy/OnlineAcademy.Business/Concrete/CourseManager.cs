using AutoMapper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.Business.Constants;
using OnlineAcademy.DataAccess.Abstract;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos.Get;
using OnlineAcademy.Entities.Dtos.Add;
using OnlineAcademy.Entities.Dtos.Update;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineAcademy.Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Aspects.Autofac.Exception;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

namespace OnlineAcademy.Business.Concrete
{
    [ExceptionLogAspect]
    [LogAspect(typeof(FileLogger))]
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;
        private readonly IMapper _mapper;

        public CourseManager(ICourseDal courseDal, IMapper mapper)
        {
            _courseDal = courseDal;
            _mapper = mapper;
        }

        [FluentValidationAspect(typeof(CourseAddDtoValidator))]
        public async Task<IResult> AddAsync(CourseAddDto courseDto)
        {
            var course = _mapper.Map<CourseAddDto, Course>(courseDto);

            await _courseDal.AddAsync(course);
            return new SuccessResult(Messages.CourseAdded);
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            var course = await _courseDal.GetAsync(c => c.Id == id);
            course.IsDeleted = true;
            await _courseDal.UpdateAsync(course);
            return new SuccessResult("Course silindi");
        }
        public async Task<IDataResult<IEnumerable<CourseWithInstructorsGetDto>>> GetAllAsync()
        {
            var data = await _courseDal.GetCoursesWithIncludesAsync();
            return new SuccessDataResult<IEnumerable<CourseWithInstructorsGetDto>>(_mapper.Map<IEnumerable<CourseWithInstructorsGetDto>>(data.ToList()));
        }

        public async Task<IDataResult<CourseDetailsGetDto>> GetByIdAsync(int id)
        {
            var data = await _courseDal.GetCourseWithIncludesByIdAsync(id);
            return new SuccessDataResult<CourseDetailsGetDto>(_mapper.Map<CourseDetailsGetDto>(data));
        }

        public async Task<IResult> HardDeleteAsync(int id)
        {
            var course = await _courseDal.GetAsync(c => c.Id == id);
            await _courseDal.DeleteAsync(course);
            return new SuccessResult("Course kalıcı olarak silindi");
        }

        public async Task<IResult> UpdateAsync(CourseUpdateDto courseDto)
        {
            var course = _courseDal.GetAsync(c => c.Id == courseDto.Id);
            await _courseDal.UpdateAsync(_mapper.Map<CourseUpdateDto, Course>(courseDto));
            return new SuccessResult("Course güncellendi");
        }
    }
}

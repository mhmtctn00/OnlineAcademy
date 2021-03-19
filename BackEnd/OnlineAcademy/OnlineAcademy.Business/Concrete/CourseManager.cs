using AutoMapper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.Business.Constants;
using OnlineAcademy.DataAccess.Abstract;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos;
using OnlineAcademy.Entities.Dtos.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CourseManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> AddAsync(CourseWithInstructorsGetDto courseDto)
        {
            try
            {
                await _unitOfWork.Course.AddAsync(_mapper.Map<CourseWithInstructorsGetDto, Course>(courseDto));
                await _unitOfWork.Course.SaveAsync();
                return new SuccessResult(Messages.CourseAdded);
            }
            catch (Exception ex)
            {
                return new ErrorResult("Hata: " + ex.Message);
            }

        }

        public async Task<IResult> DeleteAsync(CourseWithInstructorsGetDto courseDto)
        {
            var updatedCourse = _mapper.Map<CourseWithInstructorsGetDto, Course>(courseDto);
            updatedCourse.IsDeleted = true;
            await _unitOfWork.Course.UpdateAsync(updatedCourse);
            return new SuccessResult("Course silindi");
        }

        public async Task<IDataResult<IEnumerable<CourseWithInstructorsGetDto>>> GetAllAsync()
        {
            var data = await _unitOfWork.Course.GetCoursesWithIncludesAsync();
            return new SuccessDataResult<IEnumerable<CourseWithInstructorsGetDto>>(_mapper.Map<IEnumerable<CourseWithInstructorsGetDto>>(data.ToList()));
        }

        public async Task<IDataResult<CourseDetailsGetDto>> GetByIdAsync(int id)
        {
            var data = await _unitOfWork.Course.GetCourseWithIncludesByIdAsync(id);
            return new SuccessDataResult<CourseDetailsGetDto>(_mapper.Map<CourseDetailsGetDto>(data));
        }

        public async Task<IResult> HardDeleteAsync(CourseWithInstructorsGetDto courseDto)
        {
            await _unitOfWork.Course.DeleteAsync(_mapper.Map<CourseWithInstructorsGetDto, Course>(courseDto));
            return new SuccessResult("Course kalıcı olarak silindi");
        }

        public async Task<IResult> UpdateAsync(CourseWithInstructorsGetDto courseDto)
        {
            await _unitOfWork.Course.UpdateAsync(_mapper.Map<CourseWithInstructorsGetDto, Course>(courseDto));
            return new SuccessResult("Course güncellendi");
        }
    }
}

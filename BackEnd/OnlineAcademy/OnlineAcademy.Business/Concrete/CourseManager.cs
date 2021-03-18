using AutoMapper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.Business.Constants;
using OnlineAcademy.DataAccess.Abstract;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos;
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

        public async Task<IResult> AddAsync(Course course)
        {
            await _unitOfWork.Course.AddAsync(course);
            return new SuccessResult(Messages.CourseAdded);
        }

        public Task<IResult> DeleteAsync(Course course)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<CourseDto>>> GetAllAsync()
        {
            var data = await _unitOfWork.Course.GetCoursesWithIncludesAsync();
            return new SuccessDataResult<IEnumerable<CourseDto>>(_mapper.Map<IEnumerable<CourseDto>>(data.ToList()));
        }

        public async Task<IDataResult<CourseDetailsDto>> GetByCourseIdAsync(int id)
        {
            var data = await _unitOfWork.Course.GetCourseWithIncludesByIdAsync(id);
            return new SuccessDataResult<CourseDetailsDto>(_mapper.Map<CourseDetailsDto>(data));
        }

        public Task<IResult> HardDeleteAsync(Course course)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(Course course)
        {
            throw new NotImplementedException();
        }
    }
}

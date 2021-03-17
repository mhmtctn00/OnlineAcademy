using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.Business.Constants;
using OnlineAcademy.DataAccess.Abstract;
using OnlineAcademy.Entities.Concrete;
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

        public CourseManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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

        public async Task<IDataResult<IEnumerable<Course>>> GetAllAsync()
        {
            var data = await _unitOfWork.Course.GetListAsync();
            return new SuccessDataResult<IEnumerable<Course>>(data.ToList());
        }

        public Task<IDataResult<Course>> GetByCourseIdAsync(int id)
        {
            throw new NotImplementedException();
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

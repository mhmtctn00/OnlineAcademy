using AutoMapper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using OnlineAcademy.Business.Abstract;
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
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Task<IResult> AddAsync(Category course)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(Category course)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<CategoryDto>>> GetAllAsync()
        {
            var data = await _unitOfWork.Category.GetListAsync();
            return new SuccessDataResult<IEnumerable<CategoryDto>>(_mapper.Map<IEnumerable<CategoryDto>>(data.ToList()));
        }
        public async Task<IDataResult<CategoryWithCoursesDto>> GetWithCoursesByIdAsync(int id)
        {
            var data = await _unitOfWork.Category.GetAsync(c => c.Id == id);
            return new SuccessDataResult<CategoryWithCoursesDto>(_mapper.Map<CategoryWithCoursesDto>(data));
        }

        public Task<IDataResult<CategoryDto>> GetByCategoryIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDeleteAsync(Category course)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(Category course)
        {
            throw new NotImplementedException();
        }
    }
}

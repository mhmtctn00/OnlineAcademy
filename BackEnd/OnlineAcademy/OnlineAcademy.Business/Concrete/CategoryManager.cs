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
        public async Task<IResult> AddAsync(CategoryGetDto categoryDto)
        {
            var addedCategory = _mapper.Map<CategoryGetDto, Category>(categoryDto);
            await _unitOfWork.Category.AddAsync(addedCategory);
            return new SuccessResult("Category added");
        }

        public async Task<IResult> DeleteAsync(CategoryGetDto categoryDto)
        {
            var deletedCategory = _mapper.Map<CategoryGetDto, Category>(categoryDto);
            deletedCategory.IsDeleted = true;
            await _unitOfWork.Category.UpdateAsync(deletedCategory);
            return new SuccessResult("Category deleted");
        }

        public async Task<IDataResult<IEnumerable<CategoryGetDto>>> GetAllAsync()
        {
            var data = await _unitOfWork.Category.GetListAsync();
            return new SuccessDataResult<IEnumerable<CategoryGetDto>>(_mapper.Map<IEnumerable<CategoryGetDto>>(data.ToList()));
        }
        public async Task<IDataResult<CategoryWithCoursesGetDto>> GetWithCoursesByIdAsync(int id)
        {
            var data = await _unitOfWork.Category.GetWithCoursesAsync(c => c.Id == id);
            return new SuccessDataResult<CategoryWithCoursesGetDto>(_mapper.Map<Category, CategoryWithCoursesGetDto>(data));
        }

        public async Task<IDataResult<CategoryGetDto>> GetByIdAsync(int id)
        {
            var data = await _unitOfWork.Category.GetAsync(c => c.Id == id);
            return new SuccessDataResult<CategoryGetDto>(_mapper.Map<Category, CategoryGetDto>(data), "Success");
        }

        public async Task<IResult> HardDeleteAsync(CategoryGetDto categoryDto)
        {
            var deletedCategory = _mapper.Map<CategoryGetDto, Category>(categoryDto);
            await _unitOfWork.Category.DeleteAsync(deletedCategory);
            return new SuccessResult("Category hard deleted");
        }

        public async Task<IResult> UpdateAsync(CategoryGetDto categoryDto)
        {
            var updatedCategory = _mapper.Map<CategoryGetDto, Category>(categoryDto);
            await _unitOfWork.Category.UpdateAsync(updatedCategory);
            return new SuccessResult("Category deleted");
        }
    }
}

using AutoMapper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.DataAccess.Abstract;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos.Get;
using OnlineAcademy.Entities.Dtos.Add;
using OnlineAcademy.Entities.Dtos.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Exception;

namespace OnlineAcademy.Business.Concrete
{
    [ExceptionLogAspect]
    [LogAspect(typeof(FileLogger))]
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        private readonly IMapper _mapper;

        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }
        public async Task<IResult> AddAsync(CategoryAddDto categoryDto)
        {
            var addedCategory = _mapper.Map<CategoryAddDto, Category>(categoryDto);
            await _categoryDal.AddAsync(addedCategory);
            return new SuccessResult("Category added");
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            var category = await _categoryDal.GetAsync(c => c.Id == id);
            category.IsDeleted = true;
            await _categoryDal.UpdateAsync(category);
            return new SuccessResult("Category deleted");
        }

        public async Task<IDataResult<IEnumerable<CategoryGetDto>>> GetAllAsync()
        {
            var data = await _categoryDal.GetListAsync();
            return new SuccessDataResult<IEnumerable<CategoryGetDto>>(_mapper.Map<IEnumerable<CategoryGetDto>>(data.ToList()));
        }
        public async Task<IDataResult<CategoryWithCoursesGetDto>> GetWithCoursesByIdAsync(int id)
        {
            var data = await _categoryDal.GetWithCoursesAsync(c => c.Id == id);
            return new SuccessDataResult<CategoryWithCoursesGetDto>(_mapper.Map<Category, CategoryWithCoursesGetDto>(data));
        }

        public async Task<IDataResult<CategoryGetDto>> GetByIdAsync(int id)
        {
            var data = await _categoryDal.GetAsync(c => c.Id == id);
            return new SuccessDataResult<CategoryGetDto>(_mapper.Map<Category, CategoryGetDto>(data), "Success");
        }

        public async Task<IResult> HardDeleteAsync(int id)
        {
            var category = await _categoryDal.GetAsync(x => x.Id == id);
            await _categoryDal.DeleteAsync(category);
            return new SuccessResult("Category hard deleted");
        }

        public async Task<IResult> UpdateAsync(CategoryUpdateDto categoryDto)
        {
            var updatedCategory = _mapper.Map<CategoryUpdateDto, Category>(categoryDto);
            await _categoryDal.UpdateAsync(updatedCategory);
            return new SuccessResult("Category deleted");
        }
    }
}

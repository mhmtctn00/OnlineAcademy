using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.Entities.Dtos.Add;
using OnlineAcademy.Entities.Dtos.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAcademy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var resp = await _categoryService.GetAllAsync();
            return Ok(resp);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWithCoursesByIdAsync(int id)
        {
            var resp = await _categoryService.GetWithCoursesByIdAsync(id);
            return Ok(resp);
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryAddDto categoryDto)
        {
            var resp = _categoryService.AddAsync(categoryDto);
            return Ok(resp);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(CategoryUpdateDto categoryDto)
        {
            var resp = _categoryService.UpdateAsync(categoryDto);
            return Ok(resp);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var resp = _categoryService.DeleteAsync(id);
            return Ok(resp);
        }
        [HttpDelete("{id}/hard")]
        public async Task<IActionResult> HardDeleteCategory(int id)
        {
            var resp = _categoryService.HardDeleteAsync(id);
            return Ok(resp);
        }
    }
}

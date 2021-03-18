using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineAcademy.Business.Abstract;
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
            var data = await _categoryService.GetAllAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWithCoursesByIdAsync(int id)
        {
            var data = await _categoryService.GetWithCoursesByIdAsync(id);
            return Ok(data);
        }
    }
}

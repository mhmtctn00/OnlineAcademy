using Microsoft.AspNetCore.Mvc;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAcademy.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {

        private ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var resp = await _courseService.GetAllAsync();
            return Ok(resp);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var resp = await _courseService.GetByIdAsync(id);
            return Ok(resp);
        }
        [HttpPost]
        public async Task<IActionResult> AddCourse(CourseWithInstructorsGetDto courseDto)
        {
            var resp = await _courseService.AddAsync(courseDto);
            return Ok(resp);
        }
    }
}

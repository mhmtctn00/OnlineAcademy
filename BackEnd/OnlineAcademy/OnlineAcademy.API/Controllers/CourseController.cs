using Microsoft.AspNetCore.Mvc;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.Entities.Dtos;
using OnlineAcademy.Entities.Dtos.Add;
using OnlineAcademy.Entities.Dtos.Update;
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
        public async Task<IActionResult> AddCourse(CourseAddDto courseDto)
        {
            var resp = await _courseService.AddAsync(courseDto);
            return Ok(resp);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCourse(CourseUpdateDto courseDto)
        {
            var resp = await _courseService.UpdateAsync(courseDto);
            return Ok(resp);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var resp = await _courseService.DeleteAsync(id);
            return Ok(resp);
        }
        [HttpDelete("{id}/hard")]
        public async Task<IActionResult> HardDeleteCourse(int id)
        {
            var resp = await _courseService.HardDeleteAsync(id);
            return Ok(resp);
        }
    }
}

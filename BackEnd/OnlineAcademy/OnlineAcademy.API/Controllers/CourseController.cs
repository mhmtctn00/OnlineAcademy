using Microsoft.AspNetCore.Mvc;
using OnlineAcademy.Business.Abstract;
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
        public async Task<IActionResult> Index()
        {
            var data = await _courseService.GetAllAsync();
            return Ok(data);
        }
        [HttpGet("id")]
        public async Task<IActionResult> Index2(int id)
        {
            var data = await _courseService.GetByCourseIdAsync(id);
            return Ok(data);
        }
    }
}

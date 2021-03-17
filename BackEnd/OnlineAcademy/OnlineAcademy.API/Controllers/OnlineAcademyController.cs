using Microsoft.AspNetCore.Mvc;
using OnlineAcademy.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAcademy.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OnlineAcademyController : ControllerBase
    {
        private ICourseService _courseService;

        public OnlineAcademyController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await _courseService.GetAllAsync();
            return Ok(data);
        }
    }
}

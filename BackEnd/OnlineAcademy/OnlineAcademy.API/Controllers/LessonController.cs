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
    public class LessonController : ControllerBase
    {
        private ILessonService _lessonService;

        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var resp = await _lessonService.GetAllAsync();
            return Ok(resp);
        }
        [HttpPost]
        public async Task<IActionResult> AddLesson(LessonAddDto lessonDto)
        {
            var resp = await _lessonService.AddAsync(lessonDto);
            return Ok(resp);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateLesson(LessonUpdateDto lessonDto)
        {
            var resp = await _lessonService.UpdateAsync(lessonDto);
            return Ok(resp);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLesson(int id)
        {
            var resp = await _lessonService.DeleteAsync(id);
            return Ok(resp);
        }
        [HttpDelete("{id}/hard")]
        public async Task<IActionResult> HardDeleteLesson(int id)
        {
            var resp = await _lessonService.HardDeleteAsync(id);
            return Ok(resp);
        }
    }
}

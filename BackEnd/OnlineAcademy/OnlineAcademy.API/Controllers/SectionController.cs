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
    public class SectionController : ControllerBase
    {
        private ISectionService _sectionService;

        public SectionController(ISectionService sectionService)
        {
            _sectionService = sectionService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var resp = await _sectionService.GetAllAsync();
            return Ok(resp);
        }
        [HttpPost]
        public async Task<IActionResult> AddSection(SectionAddDto sectionDto)
        {
            var resp = await _sectionService.AddAsync(sectionDto);
            return Ok(resp);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSection(SectionUpdateDto sectionDto)
        {
            var resp = await _sectionService.UpdateAsync(sectionDto);
            return Ok(resp);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSection(int id)
        {
            var resp = await _sectionService.DeleteAsync(id);
            return Ok(resp);
        }
        [HttpDelete("{id}/hard")]
        public async Task<IActionResult> HardDeleteSection(int id)
        {
            var resp = await _sectionService.HardDeleteAsync(id);
            return Ok(resp);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.DataAccess.Abstract;
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
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var resp = await _commentService.GetAllAsync();
            return Ok(resp);
        }
        [HttpPost]
        public async Task<IActionResult> AddComment(CommentAddDto CommentDto)
        {
            var resp = await _commentService.AddAsync(CommentDto);
            return Ok(resp);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateComment(CommentUpdateDto CommentDto)
        {
            var resp = await _commentService.UpdateAsync(CommentDto);
            return Ok(resp);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var resp = await _commentService.DeleteAsync(id);
            return Ok(resp);
        }
        [HttpDelete("{id}/hard")]
        public async Task<IActionResult> HardDeleteComment(int id)
        {
            var resp = await _commentService.HardDeleteAsync(id);
            return Ok(resp);
        }
    }
}

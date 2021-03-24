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
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var resp = await _userService.GetAllAsync();
            return Ok(resp);
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(UserAddDto userDto)
        {
            var resp = await _userService.AddAsync(userDto);
            return Ok(resp);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUser(UserUpdateDto userDto)
        {
            var resp = await _userService.UpdateAsync(userDto);
            return Ok(resp);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var resp = await _userService.DeleteAsync(id);
            return Ok(resp);
        }
        [HttpDelete("{id}/hard")]
        public async Task<IActionResult> HardDeleteUser(int id)
        {
            var resp = await _userService.HardDeleteAsync(id);
            return Ok(resp);
        }
    }
}

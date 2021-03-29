using Core.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Mvc;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.Entities.Dtos;
using OnlineAcademy.Entities.Dtos.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAcademy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            var resp = await _authService.Login(userLoginDto);
            if (resp.Status == ResultStatus.Error)
            {
                return BadRequest(resp);
            }
            var result = await _authService.CreateAccessToken(resp.Data.Email);
            if (result.Status == ResultStatus.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserAddDto userAddDto)
        {
            var resp = await _authService.UserExist(userAddDto.Email);
            if (resp.Status == ResultStatus.Success)
            {
                return BadRequest(resp);
            }
            var r = await _authService.Register(userAddDto);
            if (r.Status == ResultStatus.Success)
                return Ok(resp);
            return BadRequest(resp);
        }
    }
}

using Core.Utilities.Results.Abstract;
using Core.Utilities.Security.JWT;
using OnlineAcademy.Entities.Dtos;
using OnlineAcademy.Entities.Dtos.Add;
using OnlineAcademy.Entities.Dtos.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Abstract
{
    public interface IAuthService
    {
        Task<IResult> Register(UserAddDto userAddDto);
        Task<IDataResult<UserLoginStep1ResponseDto>> LoginStep1(string email);
        Task<IDataResult<UserGetDto>> LoginStep2(UserLoginDto userAddDto);
        Task<byte[]> GetSalt(string email);
        Task<IResult> UserExist(string email);
        Task<IDataResult<AccessToken>> CreateAccessToken(UserAddDto user); //???????
    }
}

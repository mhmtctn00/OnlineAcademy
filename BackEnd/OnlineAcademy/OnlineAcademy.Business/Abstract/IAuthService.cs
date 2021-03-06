using Core.Utilities.Results.Abstract;
using Core.Utilities.Security;
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
        Task<IDataResult<UserGetDto>> Login(UserLoginDto userLoginDto);
        Task<byte[]> GetSalt(string email);
        Task<IResult> UserExist(string email);
        Task<IDataResult<AccessToken>> CreateAccessToken(string email); 
    }
}

using AutoMapper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.ComplexTypes;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Security.JWT;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.DataAccess.Abstract;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos;
using OnlineAcademy.Entities.Dtos.Add;
using OnlineAcademy.Entities.Dtos.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserDal _userDal;
        private ITokenHelper _tokenHelper;
        private readonly IMapper _mapper;

        public AuthManager(IUserDal userDal, ITokenHelper tokenHelper, IMapper mapper)
        {
            _userDal = userDal;
            _tokenHelper = tokenHelper;
            _mapper = mapper;
        }

        public async Task<byte[]> GetSalt(string email)
        {
            var user = await _userDal.GetAsync(u => u.Email == email);
            if (user == null)
            {
                return null;
            }
            return user.PasswordSalt;
        }
        public async Task<IDataResult<UserLoginStep1ResponseDto>> LoginStep1(string email)
        {
            var user = await _userDal.GetAsync(u => u.Email == email);
            if (user == null)
            {
                return new ErrorDataResult<UserLoginStep1ResponseDto>("user_not_found");
            }
            var token = Convert.ToBase64String(Encoding.UTF8.GetBytes(DateTime.Now.ToString()));
            var salt = Convert.ToBase64String(user.PasswordSalt);
            return new SuccessDataResult<UserLoginStep1ResponseDto>(new UserLoginStep1ResponseDto { Salt = salt, Token = token });
        }

        public Task<IDataResult<UserGetDto>> LoginStep2(UserLoginDto userLoginDto)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<AccessToken>> CreateAccessToken(UserAddDto user)
        {
            throw new NotImplementedException();
        }
        public async Task<IResult> Register(UserAddDto userAddDto)
        {
            var resp = await UserExist(userAddDto.Email);
            if (resp.Status == ResultStatus.Success)
            {
                return new ErrorResult("user_already_exist");
            }
            await _userDal.AddAsync(_mapper.Map<UserAddDto, User>(userAddDto));
            return new SuccessResult();
        }

        public async Task<IResult> UserExist(string email)
        {
            var user = await _userDal.GetAsync(u => u.Email == email);
            if (user == null)
            {
                return new ErrorResult("user_not_found");
            }
            return new SuccessResult();
        }
    }
}

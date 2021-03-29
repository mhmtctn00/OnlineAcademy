using AutoMapper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.ComplexTypes;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security;
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

        public async Task<IDataResult<UserGetDto>> Login(UserLoginDto userLoginDto)
        {
            var user = await _userDal.GetAsync(u => u.Email == userLoginDto.Email);
            if (user == null)
            {
                return new ErrorDataResult<UserGetDto>("user_not_found");
            }
            if (HashingHelper.VerifyPasswordHash(userLoginDto.Password, user.PasswordHash, user.PasswordSalt))
                return new SuccessDataResult<UserGetDto>(_mapper.Map<User, UserGetDto>(user));
            return new ErrorDataResult<UserGetDto>("user_password_or_email_wrong");
        }
        public async Task<IDataResult<AccessToken>> CreateAccessToken(string email)
        {
            var user = await _userDal.GetUserWithRolesByEmail(email);
            if (user == null)
            {
                return new ErrorDataResult<AccessToken>("user_not_found");
            }
            var accessToken = _tokenHelper.CreateToken(user, user.UserRoles.Select(ur => ur.Role).ToList());
            return new SuccessDataResult<AccessToken>(accessToken);
        }
        public async Task<IResult> Register(UserAddDto userAddDto)
        {
            var resp = await UserExist(userAddDto.Email);
            if (resp.Status == ResultStatus.Success)
            {
                return new ErrorResult("user_already_exist");
            }

            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userAddDto.Password, out passwordHash, out passwordSalt);
            var user = _mapper.Map<UserAddDto, User>(userAddDto);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            
            await _userDal.AddAsync(user);
            return new SuccessResult();
        }

        public async Task<IResult> UserExist(string email)
        {
            var user = await _userDal.GetAsync(u => u.Email == email);
            if (user == null)
            {
                return new ErrorResult("user_not_found");
            }
            return new SuccessResult("user_already_exist");
        }
    }
}

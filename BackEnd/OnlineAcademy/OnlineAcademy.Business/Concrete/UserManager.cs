using AutoMapper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.DataAccess.Abstract;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos.Add;
using OnlineAcademy.Entities.Dtos.Get;
using OnlineAcademy.Entities.Dtos.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IMapper _mapper;

        public UserManager(IUserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }
        public async Task<IResult> AddAsync(UserAddDto userDto)
        {
            var user = _mapper.Map<UserAddDto, User>(userDto);
            await _userDal.AddAsync(user);
            return new SuccessResult("User Added.");
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            var user = await _userDal.GetAsync(s => s.Id == id);
            user.IsDeleted = true;
            await _userDal.UpdateAsync(user);
            return new SuccessResult("User deleted.");
        }

        public async Task<IDataResult<IEnumerable<UserGetDto>>> GetAllAsync()
        {
            var users = await _userDal.GetListAsync();
            return new SuccessDataResult<IEnumerable<UserGetDto>>(_mapper.Map<IEnumerable<User>, IEnumerable<UserGetDto>>(users));
        }

        public async Task<IDataResult<UserGetDto>> GetByIdAsync(int id)
        {
            var user = await _userDal.GetAsync(s => s.Id == id);
            return new SuccessDataResult<UserGetDto>(_mapper.Map<User, UserGetDto>(user));
        }

        public async Task<IResult> HardDeleteAsync(int id)
        {
            var user = await _userDal.GetAsync(s => s.Id == id);
            await _userDal.DeleteAsync(user);
            return new SuccessResult("User hard deleted.");
        }

        public async Task<IResult> UpdateAsync(UserUpdateDto userDto)
        {
            var user = _mapper.Map<UserUpdateDto, User>(userDto);
            await _userDal.UpdateAsync(user);
            return new SuccessResult("User updated.");
        }
    }
}

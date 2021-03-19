using Core.Utilities.Results.Abstract;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Concrete
{
    public class UserManager : IUserService
    {
        public Task<IResult> AddAsync(UserGetDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(UserGetDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IEnumerable<UserGetDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<UserGetDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDeleteAsync(UserGetDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(UserGetDto userDto)
        {
            throw new NotImplementedException();
        }
    }
}

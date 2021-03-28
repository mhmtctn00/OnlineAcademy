using Core.Utilities.Results.Abstract;
using Core.Utilities.Security.JWT;
using OnlineAcademy.Entities.Dtos.Add;
using OnlineAcademy.Entities.Dtos.Get;
using OnlineAcademy.Entities.Dtos.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Abstract
{
    public interface IUserService
    {
        Task<IResult> AddAsync(UserAddDto userDto);
        Task<IResult> UpdateAsync(UserUpdateDto userDto);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> HardDeleteAsync(int id);
        Task<IDataResult<UserGetDto>> GetByIdAsync(int id);
        Task<IDataResult<UserGetDto>> GetByEmailAsync(string email);
        Task<IDataResult<IEnumerable<UserGetDto>>> GetAllAsync();
    }
}

using Core.Utilities.Results.Abstract;
using OnlineAcademy.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Abstract
{
    public interface IUserService
    {
        Task<IResult> AddAsync(UserGetDto userDto);
        Task<IResult> UpdateAsync(UserGetDto userDto);
        Task<IResult> DeleteAsync(UserGetDto userDto);
        Task<IResult> HardDeleteAsync(UserGetDto userDto);
        Task<IDataResult<UserGetDto>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<UserGetDto>>> GetAllAsync();
    }
}

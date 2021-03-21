using Core.Utilities.Results.Abstract;
using OnlineAcademy.Entities.Dtos.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Abstract
{
    public interface IRoleService
    {
        Task<IResult> AddAsync(RoleGetDto roleDto);
        Task<IResult> UpdateAsync(RoleGetDto roleDto);
        Task<IResult> DeleteAsync(RoleGetDto roleDto);
        Task<IResult> HardDeleteAsync(RoleGetDto roleDto);
        Task<IDataResult<RoleGetDto>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<RoleGetDto>>> GetAllAsync();
    }
}

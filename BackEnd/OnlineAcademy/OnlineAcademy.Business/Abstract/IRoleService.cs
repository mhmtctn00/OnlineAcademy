using Core.Utilities.Results.Abstract;
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
    public interface IRoleService
    {
        Task<IResult> AddAsync(RoleAddDto roleDto);
        Task<IResult> UpdateAsync(RoleUpdateDto roleDto);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> HardDeleteAsync(int id);
        Task<IDataResult<RoleGetDto>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<RoleGetDto>>> GetAllAsync();
    }
}

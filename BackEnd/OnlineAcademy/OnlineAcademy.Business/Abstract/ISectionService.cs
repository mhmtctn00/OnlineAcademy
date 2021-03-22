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
    public interface ISectionService
    {
        Task<IResult> AddAsync(SectionAddDto sectionDto);
        Task<IResult> UpdateAsync(SectionUpdateDto sectionDto);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> HardDeleteAsync(int id);
        Task<IDataResult<SectionGetDto>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<SectionGetDto>>> GetAllAsync();
    }
}

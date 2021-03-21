using Core.Utilities.Results.Abstract;
using OnlineAcademy.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Abstract
{
    public interface ISectionService
    {
        Task<IResult> AddAsync(SectionGetDto sectionDto);
        Task<IResult> UpdateAsync(SectionGetDto sectionDto);
        Task<IResult> DeleteAsync(SectionGetDto sectionDto);
        Task<IResult> HardDeleteAsync(SectionGetDto sectionDto);
        Task<IDataResult<SectionGetDto>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<SectionGetDto>>> GetAllAsync();
    }
}

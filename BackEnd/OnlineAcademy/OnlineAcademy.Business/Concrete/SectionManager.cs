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
    public class SectionManager : ISectionService
    {
        public Task<IResult> AddAsync(SectionGetDto sectionDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(SectionGetDto sectionDto)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IEnumerable<SectionGetDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SectionGetDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }


        public Task<IResult> HardDeleteAsync(SectionGetDto sectionDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(SectionGetDto sectionDto)
        {
            throw new NotImplementedException();
        }
    }
}

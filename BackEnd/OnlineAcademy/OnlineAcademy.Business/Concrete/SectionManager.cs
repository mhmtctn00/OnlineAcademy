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
    public class SectionManager : ISectionService
    {
        private readonly ISectionDal _sectionDal;
        private readonly IMapper _mapper;

        public SectionManager(ISectionDal sectionDal, IMapper mapper)
        {
            _sectionDal = sectionDal;
            _mapper = mapper;
        }
        public async Task<IResult> AddAsync(SectionAddDto sectionDto)
        {
            var section = _mapper.Map<SectionAddDto, Section>(sectionDto);
            await _sectionDal.AddAsync(section);
            return new SuccessResult("Section Added.");
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            var section = await _sectionDal.GetAsync(s => s.Id == id);
            section.IsDeleted = true;
            await _sectionDal.UpdateAsync(section);
            return new SuccessResult("Section deleted.");
        }

        public async Task<IDataResult<IEnumerable<SectionGetDto>>> GetAllAsync()
        {
            var sections = await _sectionDal.GetListAsync();
            return new SuccessDataResult<IEnumerable<SectionGetDto>>(_mapper.Map<IEnumerable<Section>, IEnumerable<SectionGetDto>>(sections));
        }

        public async Task<IDataResult<SectionGetDto>> GetByIdAsync(int id)
        {
            var section = await _sectionDal.GetAsync(s => s.Id == id);
            return new SuccessDataResult<SectionGetDto>(_mapper.Map<Section, SectionGetDto>(section));
        }

        public async Task<IResult> HardDeleteAsync(int id)
        {
            var section = await _sectionDal.GetAsync(s => s.Id == id);
            await _sectionDal.DeleteAsync(section);
            return new SuccessResult("Section hard deleted.");
        }

        public async Task<IResult> UpdateAsync(SectionUpdateDto sectionDto)
        {
            var section = _mapper.Map<SectionUpdateDto, Section>(sectionDto);
            await _sectionDal.UpdateAsync(section);
            return new SuccessResult("Section Updated.");
        }
    }
}

using AutoMapper;
using Core.Entities.Concrete;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos.Add;
using OnlineAcademy.Entities.Dtos.Get;
using OnlineAcademy.Entities.Dtos.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Mappings.AutoMapper.Profiles
{
    class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleGetDto>().ReverseMap();

            CreateMap<RoleAddDto, Role>()
                    .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<RoleUpdateDto, Role>()
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}

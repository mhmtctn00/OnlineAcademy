using AutoMapper;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Mappings.AutoMapper.Profiles
{
    class DtoProfile : Profile
    {
        public DtoProfile()
        {
            CreateMap<CourseDto, Course>().ReverseMap();
            CreateMap<CourseDetailsDto, Course>().ReverseMap();
        }
    }
}

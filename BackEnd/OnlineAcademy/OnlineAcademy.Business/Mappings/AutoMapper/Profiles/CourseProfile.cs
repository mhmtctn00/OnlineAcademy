using AutoMapper;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos.Get;
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
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<Course, CourseGetDto>().ReverseMap();

            /* Many to Many Mapping */
            CreateMap<Course, CourseWithInstructorsGetDto>()
                .ForMember(dto => dto.CourseInstructors, opt => opt.MapFrom(x => x.CourseInstructors.Select(y => y.User).ToList()));
            CreateMap<CourseWithInstructorsGetDto, Course>()
                .ForMember(opt => opt.CourseInstructors, dto => dto.MapFrom(x => x.CourseInstructors.ToList()));

            CreateMap<Course, CourseDetailsGetDto>()
                .ForMember(dto => dto.CourseInstructors, opt => opt.MapFrom(x => x.CourseInstructors.Select(y => y.User).ToList()))
                .ForMember(dto => dto.CourseStudentsCount, opt => opt.MapFrom(x => x.CourseStudents.Count()))
                .ForMember(dto => dto.CourseCategories, opt => opt.MapFrom(x => x.CourseCategories.Select(y => y.Category).ToList()));
            CreateMap<CourseDetailsGetDto, Course>()
            .ForMember(opt => opt.CourseInstructors, dto => dto.MapFrom(x => x.CourseInstructors.ToList()))
            .ForMember(opt => opt.CourseCategories, dto => dto.MapFrom(x => x.CourseCategories.ToList()));








            CreateMap<CourseAddDto, Course>()
                .ForMember(dest => dest.CourseCategories, opt => opt.MapFrom(src => src.Categories))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<CourseUpdateDto, Course>()
                .ForMember(dest => dest.CourseCategories, opt => opt.MapFrom(src => src.Categories))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}

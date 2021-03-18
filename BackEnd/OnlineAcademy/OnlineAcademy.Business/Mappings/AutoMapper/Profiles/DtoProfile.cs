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
            CreateMap<Course, CourseDto>()
                .ForMember(dto => dto.CourseTeachers, opt => opt.MapFrom(x => x.CourseTeachers.Select(y => y.User).ToList())).ReverseMap();
            CreateMap<Course, CourseDetailsDto>()
                .ForMember(dto => dto.CourseTeachers, opt => opt.MapFrom(x => x.CourseTeachers.Select(y => y.User).ToList()))
                .ForMember(dto => dto.CourseStudentsCount, opt => opt.MapFrom(x => x.CourseStudents.Count()))
                .ForMember(dto => dto.CourseCategories, opt => opt.MapFrom(x => x.CourseCategories.Select(y => y.Category).ToList())).ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryWithCoursesDto>().ReverseMap();
            CreateMap<Section, SectionDto>().ReverseMap();
            CreateMap<Lesson, LessonDto>().ReverseMap();
            CreateMap<Comment, CommentDto>().ReverseMap();
        }
    }
}

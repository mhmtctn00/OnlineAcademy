using AutoMapper;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos;
using OnlineAcademy.Entities.Dtos.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Mappings.AutoMapper.Profiles
{
    class DtoProfile : Profile
    {
        /*
        * Her entity için bir dto oluşturulacak.
        * Her entity için include'larını bir dto oluşturulacak.
        * Her entity için Update ve Add için ayrı ayrı dto oluşturulacak.
        * Hard Delete(normal Delete dahil) için id kullanılacak.
        */
        public DtoProfile()
        {
            CreateMap<User, UserGetDto>().ReverseMap();
            CreateMap<Section, SectionGetDto>().ReverseMap();
            CreateMap<Lesson, LessonGetDto>().ReverseMap();
            CreateMap<Comment, CommentGetDto>().ReverseMap();
            CreateMap<Category, CategoryGetDto>().ReverseMap();



            /* Many to Many Mapping */

            CreateMap<Category, CategoryWithCoursesGetDto>()
                .ForMember(dto => dto.Courses, opt => opt.MapFrom(x => x.CourseCategories.Select(y => y.Course).ToList()))
                .ReverseMap();

            CreateMap<UserGetDto, CourseInstructor>()
                .ForMember(opt => opt.UserId, dto => dto.MapFrom(x => x.Id))
                .ReverseMap();

            CreateMap<CategoryGetDto, CourseCategory>()
                .ForMember(opt => opt.CategoryId, dto => dto.MapFrom(x => x.Id))
                .ReverseMap();
        }
    }
}

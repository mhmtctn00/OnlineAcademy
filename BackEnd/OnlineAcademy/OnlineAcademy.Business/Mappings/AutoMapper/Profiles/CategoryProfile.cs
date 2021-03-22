using AutoMapper;
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
    class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryGetDto>().ReverseMap();

            /* Many to Many Mapping */

            CreateMap<Category, CategoryWithCoursesGetDto>()
                .ForMember(dto => dto.Courses, opt => opt.MapFrom(x => x.CourseCategories.Select(y => y.Course).ToList()))
                .ReverseMap();

            CreateMap<CategoryGetDto, CourseCategory>()
                .ForMember(opt => opt.CategoryId, dto => dto.MapFrom(x => x.Id))
                .ReverseMap();



            CreateMap<CategoryAddDto, Category>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<CategoryUpdateDto, Category>()
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}

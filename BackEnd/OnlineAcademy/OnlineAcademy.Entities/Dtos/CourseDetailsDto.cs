using Core.Entities.Abstract;
using OnlineAcademy.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Dtos
{
    public class CourseDetailsDto : CourseDto, IDto
    {
        public ICollection<CategoryDto> CourseCategories { get; set; }
        public int CourseStudentsCount { get; set; }
        public ICollection<SectionDto> Sections { get; set; }
    }
}

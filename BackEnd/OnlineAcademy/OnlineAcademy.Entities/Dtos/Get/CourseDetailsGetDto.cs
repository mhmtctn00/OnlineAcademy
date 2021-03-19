using Core.Entities.Abstract;
using OnlineAcademy.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Dtos
{
    public class CourseDetailsGetDto : CourseWithInstructorsGetDto, IDto
    {
        public ICollection<CategoryGetDto> CourseCategories { get; set; }
        public int CourseStudentsCount { get; set; }
        public ICollection<SectionGetDto> Sections { get; set; }
    }
}

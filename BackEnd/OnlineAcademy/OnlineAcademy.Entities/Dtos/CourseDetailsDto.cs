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
        public ICollection<CourseCategory> CourseCategories { get; set; }
        public ICollection<CourseStudent> CourseStudents { get; set; }
        public ICollection<Section> Sections { get; set; }
    }
}

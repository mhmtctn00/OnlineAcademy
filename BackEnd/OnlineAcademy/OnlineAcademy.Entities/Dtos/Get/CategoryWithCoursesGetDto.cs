using Core.Entities.Abstract;
using OnlineAcademy.Entities.Dtos.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Dtos.Get
{
    public class CategoryWithCoursesGetDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CourseGetDto> Courses { get; set; }
    }
}

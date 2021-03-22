using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Dtos.Get
{
    public class SectionGetDto : IDto
    {
        public int id { get; set; }
        public string Title { get; set; }
        public ICollection<LessonGetDto> Lessons { get; set; }
    }
}

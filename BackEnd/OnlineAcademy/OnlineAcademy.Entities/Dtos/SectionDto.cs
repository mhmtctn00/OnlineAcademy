using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Dtos
{
    public class SectionDto : IDto
    {
        public int id { get; set; }
        public string Title { get; set; }
        public ICollection<LessonDto> Lessons { get; set; }
    }
}

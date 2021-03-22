using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Dtos.Add
{
    public class LessonAddDto : IDto
    {
        public int SectionId { get; set; }
        public string Title { get; set; }
        public string Video { get; set; }
    }
}

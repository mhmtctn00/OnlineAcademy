using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Dtos.Get
{
    public class LessonGetDto : IDto
    {
        public int id { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public string Video { get; set; }
    }
}

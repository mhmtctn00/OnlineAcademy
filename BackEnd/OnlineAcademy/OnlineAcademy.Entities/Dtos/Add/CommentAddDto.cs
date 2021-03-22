using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Dtos.Add
{
    public class CommentAddDto : IDto
    {
        public int UserId { get; set; }
        public int LessonId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}

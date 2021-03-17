using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Concrete
{
    public class Comment : EntityBase, IEntity
    {
        public int UserId { get; set; }
        public int LessonId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public virtual User User { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}

using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace OnlineAcademy.Entities.Concrete
{
    public class User : Core.Entities.Concrete.User, IEntity
    {

        public virtual ICollection<CourseStudent> CourseStudents { get; set; }
        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    }
}

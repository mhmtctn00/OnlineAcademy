﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Concrete
{
    public class Course : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<CourseCategory> CourseCategories { get; set; }
        public virtual ICollection<CourseStudent> CourseStudents { get; set; }
        public virtual ICollection<CourseTeacher> CourseTeachers { get; set; }
    }
}

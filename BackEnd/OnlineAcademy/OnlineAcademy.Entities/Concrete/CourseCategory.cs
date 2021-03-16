using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Concrete
{
    public class CourseCategory : IEntity
    {
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Category Category { get; set; }
    }
}

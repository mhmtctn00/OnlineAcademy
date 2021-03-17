using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Concrete
{
    public class Category : EntityBase, IEntity
    {
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CourseCategory> CourseCategories { get; set; }
    }
}

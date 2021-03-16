using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Concrete
{
    public class Lesson : IEntity
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public string Video { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    }
}

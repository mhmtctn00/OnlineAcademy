using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Dtos.Add
{
    public class CategoryAddDto : IDto
    {
        public virtual int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
    }
}

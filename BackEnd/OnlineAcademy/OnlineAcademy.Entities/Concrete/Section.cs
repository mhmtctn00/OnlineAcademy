using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Concrete
{
    public class Section : EntityBase, IEntity
    {
        public int CorseId { get; set; }
        public string Title { get; set; }
    }
}

using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Dtos.Update
{
    public class SectionUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}

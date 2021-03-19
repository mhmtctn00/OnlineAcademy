﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Dtos
{
    public class CommentDto : IDto
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public virtual UserDto User { get; set; }
    }
}
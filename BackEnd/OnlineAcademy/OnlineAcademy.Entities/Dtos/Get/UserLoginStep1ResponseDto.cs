﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Dtos.Get
{
    public class UserLoginStep1ResponseDto : IDto
    {
        public string Salt { get; set; }
        public string Token { get; set; }
    }
}

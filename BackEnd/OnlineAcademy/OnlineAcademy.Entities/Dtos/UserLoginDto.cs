using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Dtos
{
    public class UserLoginDto : IDto
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Token { get; set; }
    }
}

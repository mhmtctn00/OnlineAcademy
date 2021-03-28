using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Entities.Dtos.Update
{
    public class UserUpdateDto : IDto
    {
        public int Id { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}

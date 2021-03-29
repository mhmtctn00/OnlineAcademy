using Core.DataAccess.Abstract;
using OnlineAcademy.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        Task<User> GetUserWithRolesByEmail(string email);
    }
}

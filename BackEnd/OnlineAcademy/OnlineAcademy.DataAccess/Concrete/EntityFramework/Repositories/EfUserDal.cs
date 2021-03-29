using Core.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using OnlineAcademy.DataAccess.Abstract;
using OnlineAcademy.DataAccess.Concrete.EntityFramework.Contexts;
using OnlineAcademy.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfUserDal : EfEntityRepositoryBase<User, EfOnlineAcademyContext>, IUserDal
    {
        public async Task<User> GetUserWithRolesByEmail(string email)
        {
            using (EfOnlineAcademyContext context = new EfOnlineAcademyContext())
            {
                var user = await context.Set<User>().Where(u => u.Email == email)
                    .Include(u => u.UserRoles).ThenInclude(ur => ur.Role)
                    .FirstOrDefaultAsync(u => u.Email == email);
                return user;
            }
        }
    }
}

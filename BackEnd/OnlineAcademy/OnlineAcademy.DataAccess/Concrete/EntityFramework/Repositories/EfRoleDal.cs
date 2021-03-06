using Core.DataAccess.Concrete.EntityFramework;
using Core.Entities.Concrete;
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
    public class EfRoleDal : EfEntityRepositoryBase<Role, EfOnlineAcademyContext>, IRoleDal
    {
    }
}

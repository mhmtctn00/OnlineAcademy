using Core.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using OnlineAcademy.DataAccess.Abstract;
using OnlineAcademy.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfSectionDal : EfEntityRepositoryBase<Section>, ISectionDal
    {
        public EfSectionDal(DbContext context) : base(context)
        {
        }
    }
}

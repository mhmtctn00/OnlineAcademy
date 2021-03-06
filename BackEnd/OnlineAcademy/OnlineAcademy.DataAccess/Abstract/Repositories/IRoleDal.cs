using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using OnlineAcademy.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.DataAccess.Abstract
{
    public interface IRoleDal : IEntityRepository<Role>
    {
    }
}

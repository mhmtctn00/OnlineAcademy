using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        ICategoryDal Category { get; }
        ICommentDal Comment { get; }
        ICourseDal Course { get; }
        ILessonDal Lesson { get; }
        IRoleDal Role { get; }
        ISectionDal Section { get; }
        IUserDal User { get; }
    }
}

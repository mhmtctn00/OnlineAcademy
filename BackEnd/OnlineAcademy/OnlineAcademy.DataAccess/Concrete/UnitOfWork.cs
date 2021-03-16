using OnlineAcademy.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private ICategoryDal _category;

        private ICommentDal _comment;

        private ICourseDal _course;

        private ILessonDal _lesson;

        private IRoleDal _role;

        private ISectionDal _section;

        private IUserDal _user;

        public UnitOfWork(ICategoryDal category, ICommentDal comment, ICourseDal course, ILessonDal lesson, IRoleDal role, ISectionDal section, IUserDal user)
        {
            _category = category;
            _comment = comment;
            _course = course;
            _lesson = lesson;
            _role = role;
            _section = section;
            _user = user;
        }

        public ICategoryDal Category => _category;

        public ICommentDal Comment => _comment;

        public ICourseDal Course => _course;

        public ILessonDal Lesson => _lesson;

        public IRoleDal Role => _role;

        public ISectionDal Section => _section;

        public IUserDal User => _user;
    }
}

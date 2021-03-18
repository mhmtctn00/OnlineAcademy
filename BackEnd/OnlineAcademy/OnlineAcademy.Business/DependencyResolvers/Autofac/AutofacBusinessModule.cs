using Autofac;
using Microsoft.EntityFrameworkCore;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.Business.Concrete;
using OnlineAcademy.DataAccess.Abstract;
using OnlineAcademy.DataAccess.Concrete;
using OnlineAcademy.DataAccess.Concrete.EntityFramework.Contexts;
using OnlineAcademy.DataAccess.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfOnlineAcademyContext>().As<DbContext>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            builder.RegisterType<EfCourseDal>().As<ICourseDal>();
            builder.RegisterType<CourseManager>().As<ICourseService>();

            builder.RegisterType<EfLessonDal>().As<ILessonDal>();


            builder.RegisterType<EfSectionDal>().As<ISectionDal>();


            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();

            builder.RegisterType<EfCommentDal>().As<ICommentDal>();


            builder.RegisterType<EfRoleDal>().As<IRoleDal>();


            builder.RegisterType<EfUserDal>().As<IUserDal>();

        }
    }
}

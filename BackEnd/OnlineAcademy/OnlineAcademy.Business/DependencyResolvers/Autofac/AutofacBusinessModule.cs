using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security;
using Core.Utilities.Security.JWT;
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

            builder.RegisterType<EfCourseDal>().As<ICourseDal>();
            builder.RegisterType<CourseManager>().As<ICourseService>();

            builder.RegisterType<EfLessonDal>().As<ILessonDal>();
            builder.RegisterType<LessonManager>().As<ILessonService>();

            builder.RegisterType<EfSectionDal>().As<ISectionDal>();
            builder.RegisterType<SectionManager>().As<ISectionService>();

            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();

            builder.RegisterType<EfCommentDal>().As<ICommentDal>();
            builder.RegisterType<CommentManager>().As<ICommentService>();

            builder.RegisterType<EfRoleDal>().As<IRoleDal>();

            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<UserManager>().As<IUserService>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}

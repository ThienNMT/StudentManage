using AutoMapper;
using StudentManage.Domain.Profiles;
using StudentManage.Repositories;
using StudentManage.Repositories.Data;
using StudentManage.Repositories.Interfaces;
using StudentManage.Services;
using StudentManage.Services.Interfaces;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace StudentManage.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<ISubjectService, SubjectService>(TypeLifetime.PerResolve);
            container.RegisterType<IStudentService, StudentService>(TypeLifetime.PerResolve);
            container.RegisterType<StudentManageContext>(TypeLifetime.PerResolve);
            container.RegisterType<IUnitOfWork, UnitOfWork>(TypeLifetime.PerResolve);
            container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>)).RegisterInstance(TypeLifetime.PerResolve);
            container.RegisterInstance<IMapper>(new AutoMapperConfig().RegisterAutoMapper());
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
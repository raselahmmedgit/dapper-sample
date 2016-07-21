using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DapperORM.Core.Repositories;
using DapperORM.Core.Services;
using Ninject;

namespace DapperORM.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ResolveDependency();
        }

        public void ResolveDependency()
        {
            const string paramName = "dbContext";
            var kernel = new StandardKernel();
            var dbContext = new DbContext();
            kernel.Bind(typeof(IBaseService<>)).To(typeof(BaseService<>)).WithConstructorArgument(paramName, dbContext);
            kernel.Bind<IUserService>().To<UserService>().WithConstructorArgument(paramName, dbContext);


            kernel.Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>)).WithConstructorArgument(paramName, dbContext);
            kernel.Bind<IUserRepository>().To<UserRepository>().WithConstructorArgument(paramName, dbContext);


            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}

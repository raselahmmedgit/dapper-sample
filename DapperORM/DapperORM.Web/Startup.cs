using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DapperORM.Web.Startup))]
namespace DapperORM.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreApp.Web.Startup))]
namespace StoreApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

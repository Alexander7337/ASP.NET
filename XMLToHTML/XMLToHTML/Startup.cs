using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XMLToHTML.Startup))]
namespace XMLToHTML
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

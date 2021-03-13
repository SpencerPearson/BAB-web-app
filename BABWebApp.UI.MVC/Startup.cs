using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BABWebApp.UI.MVC.Startup))]
namespace BABWebApp.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

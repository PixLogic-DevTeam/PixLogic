using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITI.PixLogic.WebSite.Startup))]
namespace ITI.PixLogic.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITI.PixLogic.View.WebSite.Startup))]
namespace ITI.PixLogic.View.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WunderTwin.Startup))]
namespace WunderTwin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

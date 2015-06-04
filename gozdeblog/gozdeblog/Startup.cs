using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gozdeblog.Startup))]
namespace gozdeblog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

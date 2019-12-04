using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testt.Startup))]
namespace testt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

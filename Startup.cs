using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(motionYield.Startup))]
namespace motionYield
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

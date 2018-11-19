using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WaterLogicc.Startup))]
namespace WaterLogicc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrossBeacon.WebMvc.Startup))]
namespace CrossBeacon.WebMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

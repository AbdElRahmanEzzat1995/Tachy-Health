using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TachyHealth.Startup))]
namespace TachyHealth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

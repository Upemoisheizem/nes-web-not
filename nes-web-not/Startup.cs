using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nes_web_not.Startup))]
namespace nes_web_not
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

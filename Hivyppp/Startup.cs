using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hivyppp.Startup))]
namespace Hivyppp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

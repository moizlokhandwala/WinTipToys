using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wintip_Toys.Startup))]
namespace Wintip_Toys
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

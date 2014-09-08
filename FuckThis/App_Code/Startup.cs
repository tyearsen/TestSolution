using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FuckThis.Startup))]
namespace FuckThis
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

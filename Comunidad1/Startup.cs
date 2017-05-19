using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comunidad1.Startup))]
namespace Comunidad1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

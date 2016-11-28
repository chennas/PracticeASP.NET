using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetClientLocation.Startup))]
namespace GetClientLocation
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

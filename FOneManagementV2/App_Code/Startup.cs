using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FOneManagement.Startup))]
namespace FOneManagement
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

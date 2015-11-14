using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TWMe.Startup))]
namespace TWMe
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlintecLogin.Startup))]
namespace FlintecLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

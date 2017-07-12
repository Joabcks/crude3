using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(crude3.Startup))]
namespace crude3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

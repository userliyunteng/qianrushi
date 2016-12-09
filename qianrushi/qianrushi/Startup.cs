using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(qianrushi.Startup))]
namespace qianrushi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

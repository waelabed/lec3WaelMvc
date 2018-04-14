using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lec3.Startup))]
namespace Lec3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

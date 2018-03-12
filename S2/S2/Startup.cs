using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S2.Startup))]
namespace S2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WealthGuide.Startup))]
namespace WealthGuide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

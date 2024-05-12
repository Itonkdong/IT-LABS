using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LV7.Startup))]
namespace LV7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

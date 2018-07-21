using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HHZ.Startup))]
namespace HHZ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

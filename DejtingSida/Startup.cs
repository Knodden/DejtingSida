using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DejtingSida.Startup))]
namespace DejtingSida
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

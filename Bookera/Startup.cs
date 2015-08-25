using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bookera.Startup))]
namespace Bookera
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

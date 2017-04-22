using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jonesneil.Startup))]
namespace jonesneil
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

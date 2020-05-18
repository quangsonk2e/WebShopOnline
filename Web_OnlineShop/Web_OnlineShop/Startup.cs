using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_OnlineShop.Startup))]
namespace Web_OnlineShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EatOnline.Startup))]
namespace EatOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

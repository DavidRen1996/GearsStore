using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GearsStore.Startup))]
namespace GearsStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

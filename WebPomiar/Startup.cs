using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPomiar.Startup))]
namespace WebPomiar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
